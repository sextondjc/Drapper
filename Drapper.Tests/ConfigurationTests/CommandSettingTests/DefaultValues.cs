// ----------------------------------------------------------------------------------------------------------
// author   : David Sexton (@sextondjc)
// created  : 2016-08-28 (23:44)
// modified : 2017-01-09 (00:14)
// 
// This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of 
// this source code package.
//  ----------------------------------------------------------------------------------------------------------

#region

using System.Data;
using Dapper;
using Drapper.Configuration;
using Xunit;
using static Xunit.Assert;

#endregion

namespace Drapper.Tests.ConfigurationTests.CommandSettingTests
{    
    public class DefaultValues
    {
        // these tests are really just to:
        //   1. test the defaults are as expected. 
        //   2. get my unit test coverage metric up to 100% for this class (yes, I am that shallow). 

        [Fact]
        public void CommandTextReturnsNullByDefault()
        {
            var setting = new CommandSetting();
            Equal(null, setting.CommandText);
        }

        [Fact]
        public void CommandTimeoutReturnsThirtyByDefault()
        {
            var setting = new CommandSetting();
            Equal(30, setting.CommandTimeout);
        }

        [Fact]
        public void CommandTypeReturnsTextByDefault()
        {
            var setting = new CommandSetting();
            Equal(CommandType.Text, setting.CommandType);
        }

        [Fact]
        public void CommandFlagsReturnsNoneByDefault()
        {
            var setting = new CommandSetting();
            Equal(CommandFlags.None, setting.Flags);
        }

        [Fact]
        public void IsolationLevelDefaultsToSerializable()
        {
            var setting = new CommandSetting();
            Equal(IsolationLevel.Serializable, setting.IsolationLevel);
        }
    }
}