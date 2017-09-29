//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:57)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Databases.Integration.Tests;
using Xunit;

namespace Drapper.MySql.Integration.Tests
{
    [Collection("Drapper.MySql.Execute")]
    public class MySqlExecute : Execute
    {
        public MySqlExecute(MySqlExecuteFixture serverFixture) : base(serverFixture)
        {
        }
    }
}