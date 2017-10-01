//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Settings.Databases.Unit.Tests.ConnectionStringSettingTests
{
    public class Constructor
    {
        [Fact]
        public void NullEmptyWhitespaceAliasThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting(null, "providerName", "connectionString"));
            var empty = Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting(string.Empty, "providerName", "connectionString"));
            var whitespace = Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting(" ", "providerName", "connectionString"));

            const string expect = "Value cannot be null.\r\nParameter name: alias";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceConnectionStringThrowsArgumentNullException()
        {
            var nulled =
                Throws<ArgumentNullException>(() => new ConnectionStringSetting("alias", "providerName", null));
            var empty = Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting("alias", "providerName", string.Empty));
            var whitespace =
                Throws<ArgumentNullException>(() => new ConnectionStringSetting("alias", "providerName", ""));

            const string expect = "Value cannot be null.\r\nParameter name: connectionString";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceProviderNameThrowsArgumentNullException()
        {
            var nulled =
                Throws<ArgumentNullException>(() =>
                    new ConnectionStringSetting("alias", null, "connectionString"));
            var empty = Throws<ArgumentNullException>(() =>
                new ConnectionStringSetting("alias", string.Empty, "connectionString"));
            var whitespace =
                Throws<ArgumentNullException>(
                    () => new ConnectionStringSetting("alias", " ", "connectionString"));

            const string expect = "Value cannot be null.\r\nParameter name: providerName";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void Successfully()
        {
            const string alias = "test";
            const string providerName = "System.Data.SqlClient";
            const string connectionString =
                "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Zulu.Tests;Integrated Security=true";
            var result = new ConnectionStringSetting(alias, providerName, connectionString);
            Equal(alias, result.Alias);
            Equal(providerName, result.ProviderName);
            Equal(connectionString, result.ConnectionString);
        }
    }
}