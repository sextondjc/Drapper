//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using static Drapper.Validation.Contract;

namespace Drapper.Settings.Databases
{
    public class DatabaseCommandTypeSetting : IDatabaseCommandTypeSetting
    {
        public DatabaseCommandTypeSetting(string name, IDictionary<string, DatabaseCommandSetting> commands)
        {
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(name), Messages.NullEmptyWhitespaceName,
                nameof(name));
            Require<ArgumentNullException>(commands != null, Messages.NullCommandsPassed, nameof(commands),
                name);
            Require<ArgumentException>(commands.Any(), Messages.EmptyDictionaryPassed, name);

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