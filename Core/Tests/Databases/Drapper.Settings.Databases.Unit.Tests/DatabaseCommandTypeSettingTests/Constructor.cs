//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Settings.Databases.Unit.Tests.DatabaseCommandTypeSettingTests
{
    public class Constructor
    {
        public Constructor()
        {
            _commands = new Dictionary<string, DatabaseCommandSetting>
            {
                ["test"] = new DatabaseCommandSetting("Test", "select 1")
            };
        }

        private readonly IDictionary<string, DatabaseCommandSetting> _commands;

        [Fact]
        public void EmptyCommandsThrowArgumentException()
        {
            var result = Throws<ArgumentException>(() =>
                new DatabaseCommandTypeSetting("test", new Dictionary<string, DatabaseCommandSetting>()));
            const string expect = "'test' must have at least 1 CommandSetting to be valid. Please check settings.";
            Equal(expect, result.Message);
        }

        [Fact]
        public void NullCommandsThrowsArgumentNullException()
        {
            var result = Throws<ArgumentNullException>(() => new DatabaseCommandTypeSetting("test", null));
            const string expect =
                "Value cannot be null.\r\nParameter name: commands. The commands collection for 'test' is null. Please check settings.";
            Equal(expect, result.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceNameThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() => new DatabaseCommandTypeSetting(null, _commands));
            var empty = Throws<ArgumentNullException>(() =>
                new DatabaseCommandTypeSetting(string.Empty, _commands));
            var whitespace = Throws<ArgumentNullException>(() => new DatabaseCommandTypeSetting("", _commands));

            const string expect =
                "Value cannot be null.\r\nParameter name: name. All type entries must have a name to be valid. Please check settings.";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new DatabaseCommandTypeSetting("test", _commands);
            Equal("test", result.Name);
            NotNull(result.Commands);
            True(result.Commands.Any());
            Equal(1, result.Commands.Count);
        }
    }
}