// ----------------------------------------------------------------------------------------------------------
// author   : David Sexton (sexto)
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

#endregion

namespace Drapper.Tests.ConfigurationTests.CommandSettingTests
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
            var setting = new CommandSetting();
            AreEqual(null, setting.CommandText);
        }

        [TestMethod]
        public void CommandTimeoutReturnsThirtyByDefault()
        {
            var setting = new CommandSetting();
            AreEqual(30, setting.CommandTimeout);
        }

        [TestMethod]
        public void CommandTypeReturnsTextByDefault()
        {
            var setting = new CommandSetting();
            AreEqual(CommandType.Text, setting.CommandType);
        }

        [TestMethod]
        public void CommandFlagsReturnsNoneByDefault()
        {
            var setting = new CommandSetting();
            AreEqual(CommandFlags.None, setting.Flags);
        }

        [TestMethod]
        public void IsolationLevelDefaultsToSerializable()
        {
            var setting = new CommandSetting();
            AreEqual(IsolationLevel.Serializable, setting.IsolationLevel);
        }
    }
}