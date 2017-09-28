//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Xunit;

namespace Drapper.Settings.Databases.Unit.Tests.ConnectionStringSettingTests
{
    public class Constructor
    {
        [Fact]
        public void NullEmptyWhitespaceAliasThrowsArgumentNullException()
        {
            var nulled = Assert.Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting(null, "providerName", "connectionString"));
            var empty = Assert.Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting(string.Empty, "providerName", "connectionString"));
            var whitespace = Assert.Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting(" ", "providerName", "connectionString"));

            const string expect = "Value cannot be null.\r\nParameter name: alias";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceConnectionStringThrowsArgumentNullException()
        {
            var nulled =
                Assert.Throws<ArgumentNullException>(() => new ConnectionStringSetting("alias", "providerName", null));
            var empty = Assert.Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting("alias", "providerName", string.Empty));
            var whitespace =
                Assert.Throws<ArgumentNullException>(() => new ConnectionStringSetting("alias", "providerName", ""));

            const string expect = "Value cannot be null.\r\nParameter name: connectionString";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceProviderNameThrowsArgumentNullException()
        {
            var nulled =
                Assert.Throws<ArgumentNullException>(() =>
                    new ConnectionStringSetting("alias", null, "connectionString"));
            var empty = Assert.Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting("alias", string.Empty, "connectionString"));
            var whitespace =
                Assert.Throws<ArgumentNullException>(
                    () => new ConnectionStringSetting("alias", " ", "connectionString"));

            const string expect = "Value cannot be null.\r\nParameter name: providerName";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void Successfully()
        {
            const string alias = "test";
            const string providerName = "System.Data.SqlClient";
            const string connectionString =
                "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Zulu.Tests;Integrated Security=true";
            var result = new ConnectionStringSetting(alias, providerName, connectionString);
            Assert.Equal(alias, result.Alias);
            Assert.Equal(providerName, result.ProviderName);
            Assert.Equal(connectionString, result.ConnectionString);
        }
    }
}