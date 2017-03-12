// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Dapper;
using Drapper.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Drapper.Tests.CommandSettingTests
{
    [TestClass]
    public class DefaultValues
    {
        // these tests are really just to:
        //   1. test the defaults are as expected. 
        //   2. get my unit test coverage metric up to 100% for this class (yes, I am that shallow). 

        [TestMethod]
        public void CommandTextReturnsNullByDefault()
        {
            var defintionEntry = new CommandSetting();
            Assert.AreEqual(null, defintionEntry.CommandText);
        }

        [TestMethod]
        public void CommandTimeoutReturnsThirtyByDefault()
        {
            var defintionEntry = new CommandSetting();
            Assert.AreEqual(30, defintionEntry.CommandTimeout);
        }

        [TestMethod]
        public void CommandTypeReturnsTextByDefault()
        {
            var defintionEntry = new CommandSetting();
            Assert.AreEqual(CommandType.Text, defintionEntry.CommandType);
        }

        [TestMethod]
        public void CommandFlagsReturnsNoneByDefault()
        {
            var defintionEntry = new CommandSetting();
            Assert.AreEqual(CommandFlags.None, defintionEntry.Flags);
        }

        [TestMethod]
        public void IsolationLevelDefaultsToSerializable()
        {
            var commandSetting = new CommandSetting();
            Assert.AreEqual(IsolationLevel.Serializable, commandSetting.IsolationLevel);
        }
    }
}
