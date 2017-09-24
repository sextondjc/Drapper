using System;
using System.Data;
using Xunit;

namespace Drapper.Settings.Databases.Unit.Tests.DatabaseCommandSettingTests
{
    public class Constructor
    {
        [Fact]
        public void NullEmptyWhitespaceAliasThrowsArgumentNullException()
        {
            var nulled = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandSetting(null, "select 1"));
            var empty = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandSetting(string.Empty, "select 1"));
            var whitespace = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandSetting("", "select 1"));
            
            const string expect = "Value cannot be null.\r\nParameter name: connectionAlias";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceCommandTextThrowsArgumentNullException()
        {
            var nulled = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandSetting("alias", null));
            var empty = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandSetting("alias", string.Empty));
            var whitespace = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandSetting("alias", ""));
            
            const string expect = "Value cannot be null.\r\nParameter name: commandText";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void ReturnsDefaults()
        {
            const string alias = "alias";
            const string commandText = "select 1;";

            var result = new DatabaseCommandSetting(alias, commandText);

            Assert.Equal(commandText, result.CommandText);
            Assert.Equal(30, result.CommandTimeout);
            Assert.Equal(CommandType.Text, result.CommandType);
            Assert.Equal(alias, result.ConnectionAlias);
            Assert.Equal(CommandFlagSetting.None, result.Flags);
            Assert.Equal(IsolationLevel.Serializable, result.IsolationLevel);
            Assert.Equal("Id", result.Split);            
        }

        [Fact]
        public void AssignsValuesSuccessfully()
        {
            const string commandText = "select 1;";
            const int timeout = 45;
            const CommandType commandType = CommandType.StoredProcedure;
            const string alias = "alias";
            const CommandFlagSetting flag = CommandFlagSetting.Pipelined;
            const IsolationLevel isolationLevel = IsolationLevel.Chaos;
            const string split = "field";

            var result = new DatabaseCommandSetting(
                alias, 
                commandText, 
                commandType, 
                timeout, 
                split, 
                flag, 
                isolationLevel);

            Assert.Equal(commandText, result.CommandText);
            Assert.Equal(timeout, result.CommandTimeout);
            Assert.Equal(commandType, result.CommandType);
            Assert.Equal(alias, result.ConnectionAlias);
            Assert.Equal(flag, result.Flags);
            Assert.Equal(isolationLevel, result.IsolationLevel);
            Assert.Equal(split, result.Split);
        }
    }
}
