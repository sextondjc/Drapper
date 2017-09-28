//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.25 (00:04)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Tests;
using Xunit;

namespace Drapper.SqlServer.Tests
{
    [Collection("Drapper.SqlServer.Query")]
    public class SqlServerQuery : Query
    {
        public SqlServerQuery(SqlServerQueryFixture serverFixture) : base(serverFixture)
        {
        }
    }
}