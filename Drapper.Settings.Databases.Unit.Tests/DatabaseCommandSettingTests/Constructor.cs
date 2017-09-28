using System;
using System.Data;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Settings.Databases.Unit.Tests.DatabaseCommandSettingTests
{
    public class Constructor
    {
        [Fact]
        public void NullEmptyWhitespaceAliasThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() => new DatabaseCommandSetting(null, "select 1"));
            var empty = Throws<ArgumentNullException>(() => new DatabaseCommandSetting(string.Empty, "select 1"));
            var whitespace = Throws<ArgumentNullException>(() => new DatabaseCommandSetting("", "select 1"));
            
            const string expect = "Value cannot be null.\r\nParameter name: connectionAlias";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceCommandTextThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() => new DatabaseCommandSetting("alias", null));
            var empty = Throws<ArgumentNullException>(() => new DatabaseCommandSetting("alias", string.Empty));
            var whitespace = Throws<ArgumentNullException>(() => new DatabaseCommandSetting("alias", ""));
            
            const string expect = "Value cannot be null.\r\nParameter name: commandText";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void ReturnsDefaults()
        {
            const string alias = "alias";
            const string commandText = "select 1;";

            var result = new DatabaseCommandSetting(alias, commandText);

            Equal(commandText, result.CommandText);
            Equal(30, result.CommandTimeout);
            Equal(CommandType.Text, result.CommandType);
            Equal(alias, result.ConnectionAlias);
            Equal(CommandFlagSetting.None, result.Flags);
            Equal(IsolationLevel.Serializable, result.IsolationLevel);
            Equal("Id", result.Split);            
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

            Equal(commandText, result.CommandText);
            Equal(timeout, result.CommandTimeout);
            Equal(commandType, result.CommandType);
            Equal(alias, result.ConnectionAlias);
            Equal(flag, result.Flags);
            Equal(isolationLevel, result.IsolationLevel);
            Equal(split, result.Split);
        }

        [Theory]
        [InlineData(-1, IsolationLevel.Unspecified)]
        [InlineData(16, IsolationLevel.Chaos)]
        [InlineData(256, IsolationLevel.ReadUncommitted)]
        [InlineData(4096, IsolationLevel.ReadCommitted)]
        [InlineData(65536, IsolationLevel.RepeatableRead)]
        [InlineData(1048576, IsolationLevel.Serializable)]
        [InlineData(16777216, IsolationLevel.Snapshot)]
        [InlineData(0, IsolationLevel.Serializable)] // no value should default to serializable.
        public void AssignsIsolationLevelSuccessfully(int value, IsolationLevel expected)
        {
            const string alias = "alias";
            const string commandText = "select 1;";
            
            var result = new DatabaseCommandSetting(alias, commandText, isolationLevel: (IsolationLevel)value);
            var isolationLevel = (IsolationLevel)value;

            Equal(expected, result.IsolationLevel);
            Equal(value, (int)isolationLevel);
        }
    }
}
