//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (15:51)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Xunit;

namespace Drapper.MySql.Integration.Tests
{
    [CollectionDefinition("Drapper.MySql.QueryAsync")]
    public class MySqlQueryAsyncFixtureCollection : ICollectionFixture<MySqlQueryAsyncFixture>
    {
    }
}