//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (21:36)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Databases.Integration.Tests;
using Xunit;

namespace Drapper.MySql.Integration.Tests
{
    [Collection("Drapper.MySql.ExecuteAsync")]
    public class MySqlExecuteAsync : ExecuteAsync
    {
        public MySqlExecuteAsync(MySqlExecuteAsyncFixture serverFixture) : base(serverFixture)
        {
        }
    }
}