using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Drapper.Settings.Databases.Unit.Tests.DatabaseCommandTypeSettingTests
{
    public class Constructor
    {
        private readonly IDictionary<string, DatabaseCommandSetting> _commands;

        public Constructor()
        {
            _commands = new Dictionary<string, DatabaseCommandSetting>
            {
                ["test"] = new DatabaseCommandSetting("Test", "select 1")
            };
        }

        [Fact]
        public void NullEmptyWhitespaceNameThrowsArgumentNullException()
        {
            var nulled = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandTypeSetting(null, _commands));
            var empty = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandTypeSetting(string.Empty, _commands));
            var whitespace = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandTypeSetting("", _commands));

            const string expect = "Value cannot be null.\r\nParameter name: name. All type entries must have a name to be valid. Please check settings.";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullCommandsThrowsArgumentNullException()
        {
            var result = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandTypeSetting("test", null));
            const string expect = "Value cannot be null.\r\nParameter name: commands. The commands collection for 'test' is null. Please check settings.";
            Assert.Equal(expect, result.Message);
        }

        [Fact]
        public void EmptyCommandsThrowArgumentException()
        {
            var result = Assert.Throws<ArgumentException>(() => new DatabaseCommandTypeSetting("test", new Dictionary<string, DatabaseCommandSetting>()));
            const string expect = "'test' must have at least 1 CommandSetting to be valid. Please check settings.";
            Assert.Equal(expect, result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new DatabaseCommandTypeSetting("test", _commands);
            Assert.Equal("test", result.Name);
            Assert.NotNull(result.Commands);
            Assert.True(result.Commands.Any());
            Assert.Equal(1, result.Commands.Count);
        }
    }
}
