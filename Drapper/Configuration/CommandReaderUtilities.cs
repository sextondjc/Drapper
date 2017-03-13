// ----------------------------------------------------------------------------------------------------------
// author   : David Sexton (sexto)
// created  : 2017-03-09 (11:44)
// modified : 2017-03-09 (18:53)
// 
// This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of 
// this source code package.
//  ----------------------------------------------------------------------------------------------------------

#region

using System;
using System.IO;
using System.Linq;
using static Drapper.Validation.Contract;

#endregion

namespace Drapper.Configuration
{
    /// <summary>
    /// Handles actions common to all command readers. 
    /// </summary>
    internal sealed class CommandReaderUtilities
    {
        private readonly ISettings _settings;

        internal CommandReaderUtilities(ISettings settings)
        {
            Require<ArgumentNullException>(settings != null, ErrorMessages.NullSettingsPassed);
            _settings = settings;
        }

        internal NamespaceSetting GetNamespaceSetting(Type type)
        {
            var result = _settings.Namespaces.SingleOrDefault(x => x.Namespace == type.Namespace);

            if (result != null)
            {
                return result;
            }

            // loop backwards till we find a match
            foreach (var setting in _settings.Namespaces)
            {
                var typeNamespace = type.Namespace;
                var periods = typeNamespace.Count(x => x == '.');

                for (var i = periods; i > 0; i--)
                {
                    if (setting.Namespace == typeNamespace)
                    {
                        return setting;
                    }
                    typeNamespace = typeNamespace.Substring(0, typeNamespace.LastIndexOf('.'));
                }
            }

            // if we reach here, we've got nothing.
            return null;
        }

        internal TypeSetting GetTypeSetting(
            NamespaceSetting namespaceSetting,
            Type type)
        {
            // check if it has a type setting.
            var typeSetting = namespaceSetting.Types?.SingleOrDefault(x => x.Name == type.FullName);

            // if it's not null, perhaps there's a definition in the settings file already.
            if (typeSetting != null)
            {
                return typeSetting;
            }

            return null;
        }

        internal CommandSetting GetCommandSetting(
            NamespaceSetting namespaceSetting,
            TypeSetting typeSetting,
            string key)
        {
            var entry = typeSetting.Commands?.SingleOrDefault(x => x.Key == key);

            // might be part of the type setting already.
            if (entry != null && entry.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(entry.Value.Key))
                {
                    return entry.Value.Value;
                }
            }

            return null;
        }

        /// <summary>
        /// Lifted pretty much directly from http://stackoverflow.com/a/35218619/6170587 with minor edits.         
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="basePath"></param>
        /// <returns></returns>
        internal string GetAbsolutePath(string relativePath, string basePath = null)
        {
            if (basePath == null)
            {
                basePath = Path.GetFullPath("."); // quick way of getting current working directory
            }
            else
            {
                basePath = GetAbsolutePath(basePath, null); // to be REALLY sure ;)
            }
            var path = ".";

            // specific for windows paths starting on \ - they need the drive added to them.
            // I constructed this piece like this for possible Mono support.
            if (!Path.IsPathRooted(relativePath) || "\\".Equals(Path.GetPathRoot(relativePath)))
            {
                if (relativePath.StartsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    path = Path.Combine(Path.GetPathRoot(basePath), relativePath.TrimStart(Path.DirectorySeparatorChar));
                }
                else
                {
                    path = Path.Combine(basePath, relativePath);
                }
            }
            else
            {
                path = relativePath;
            }
            // resolves any internal "..\" to get the true full path.
            return Path.GetFullPath(path);
        }

        private static class ErrorMessages
        {
            internal const string NullSettingsPassed = "The ISettings instance passed was null.";
        }
    }
}
