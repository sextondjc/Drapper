// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Drapper.Tests.DbConnectorTests
{
    /// <summary>
    /// Tests the <see cref="DbConnector"/> constructor.
    /// </summary>
    [TestClass]
    public class Constructor
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullConnectionStringSettingsProviderThrowsArgumentException()
        {
            var connector = new DbConnector(null);
        }

        [TestMethod]
        public void SupportsConnectionStringsSettingsFromSettingsProvider()
        {
            var provider = new Settings();
            var connector = new DbConnector(provider);
        }
    }
}
