using Xunit;
using static Xunit.Assert;

namespace Drapper.Settings.Databases.Unit.Tests.CommandFlagSettingTests
{
    public class EnumerateValues
    {

        [Theory]
        [InlineData(CommandFlagSetting.None, 0)]        
        [InlineData(CommandFlagSetting.Buffered, 1)]
        [InlineData(CommandFlagSetting.Pipelined, 2)]
        [InlineData(CommandFlagSetting.NoCache, 4)]
        [InlineData(CommandFlagSetting.None | CommandFlagSetting.Buffered, 1)]
        [InlineData(CommandFlagSetting.None | CommandFlagSetting.Pipelined, 2)]
        [InlineData(CommandFlagSetting.None | CommandFlagSetting.NoCache, 4)]
        [InlineData(CommandFlagSetting.Buffered | CommandFlagSetting.Pipelined, 3)]
        [InlineData(CommandFlagSetting.Buffered | CommandFlagSetting.NoCache, 5)]
        [InlineData(CommandFlagSetting.Pipelined | CommandFlagSetting.NoCache, 6)]
        public void Successfully(CommandFlagSetting setting, int value)
        {            
            Equal(value, (int) setting);
        }
    }
}
