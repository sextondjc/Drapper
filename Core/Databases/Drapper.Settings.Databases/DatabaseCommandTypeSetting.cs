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
    public class DatabaseCommandTypeSetting : IDatabaseCommandTypeSetting
    {
        public DatabaseCommandTypeSetting(string name, IDictionary<string, DatabaseCommandSetting> commands)
        {
            Contract.Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(name), Messages.NullEmptyWhitespaceName,
                nameof(name));
            Contract.Require<ArgumentNullException>(commands != null, Messages.NullCommandsPassed, nameof(commands),
                name);
            Contract.Require<ArgumentException>(commands.Any(), Messages.EmptyDictionaryPassed, name);

            Name = name;
            Commands = commands;
        }

        public string Name { get; }

        public IDictionary<string, DatabaseCommandSetting> Commands { get; }

        private static class Messages
        {
            internal const string NullEmptyWhitespaceName
                = @"{0}. All type entries must have a name to be valid. Please check settings.";

            internal const string NullCommandsPassed
                = "{0}. The commands collection for '{1}' is null. Please check settings.";

            internal const string EmptyDictionaryPassed
                = "'{0}' must have at least 1 CommandSetting to be valid. Please check settings.";
        }
    }
}