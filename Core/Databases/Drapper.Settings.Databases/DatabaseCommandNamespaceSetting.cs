//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using Drapper.Validation;

namespace Drapper.Settings.Databases
{
    public class DatabaseCommandNamespaceSetting : IDatabaseCommandNamespaceSetting
    {
        public DatabaseCommandNamespaceSetting(string @namespace,
            IEnumerable<DatabaseCommandTypeSetting> types)
        {
            Contract.Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(@namespace), Messages.NullName,
                nameof(@namespace));
            Contract.Require<ArgumentNullException>(types != null, Messages.NullCommandsPassed, nameof(types),
                @namespace);
            var typeSettings = types as DatabaseCommandTypeSetting[] ?? types.ToArray();
            Contract.Require<ArgumentException>(typeSettings.Any(), Messages.EmptyListPassed, @namespace);
            Namespace = @namespace;
            Types = typeSettings;
        }

        public string Namespace { get; set; }
        public IEnumerable<ITypeSetting<DatabaseCommandSetting>> Types { get; set; }

        private static class Messages
        {
            internal const string NullName =
                    "{0}. All namespace entries must have a name to be valid. Please check settings for an empty namespace namespace."
                ;

            internal const string NullCommandsPassed
                = "{0}. The types collection for '{1}' is null. Please check settings.";

            internal const string EmptyListPassed
                = "'{0}' must have at least 1 Type setting to be valid. Please check settings.";
        }
    }
}