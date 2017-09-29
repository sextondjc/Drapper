//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:54)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Xunit;

namespace Drapper.MySql.Integration.Tests
{
    [CollectionDefinition("Drapper.MySql.Execute")]
    public class MySqlExecuteFixtureCollection : ICollectionFixture<MySqlExecuteFixture>
    {
    }
}