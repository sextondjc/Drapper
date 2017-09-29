//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:57)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Databases.Integration.Tests;
using Drapper.Tests;
using Xunit;

namespace Drapper.SqlServer.Tests
{
    [Collection("Drapper.SqlServer.Execute")]
    public class SqlServerExecute : Execute
    {
        public SqlServerExecute(SqlServerExecuteFixture serverFixture) : base(serverFixture)
        {
        }
    }
}