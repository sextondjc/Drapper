//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (15:51)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Databases.Integration.Tests;
using Drapper.Tests;
using Xunit;

namespace Drapper.SqlServer.Tests
{
    [Collection("Drapper.SqlServer.QueryAsync")]
    public class SqlServerQueryAsync : QueryAsync
    {
        public SqlServerQueryAsync(SqlServerQueryAsyncFixture serverFixture) : base(serverFixture)
        {
        }
    }
}