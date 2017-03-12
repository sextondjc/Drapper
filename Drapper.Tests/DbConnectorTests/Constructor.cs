// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration;
using System;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests.DbConnectorTests
{
    /// <summary>
    /// Tests the <see cref="DbConnector"/> constructor.
    /// </summary>    
    public class Constructor
    {
        [Fact]
        public void NullConnectionStringSettingsProviderThrowsArgumentNullException()
        {
            var connector = Throws<ArgumentNullException>(() => new DbConnector(null));
        }

        [Fact]
        public void SupportsConnectionStringsSettingsFromSettingsProvider()
        {
            var provider = new Settings();
            var connector = new DbConnector(provider);
            NotNull(connector);
        }
    }
}
