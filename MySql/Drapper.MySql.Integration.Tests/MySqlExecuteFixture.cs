//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:53)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Data.SqlClient;
using Drapper.Databases.Integration.Tests;
using Drapper.MySql.Integration.Tests.Setup;
using Drapper.Tests.Common;

namespace Drapper.MySql.Integration.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MySqlExecuteFixture : ExecuteFixture
    {
        public MySqlExecuteFixture() : base(CommanderHelper.CreateCommander<Execute>(() => SqlClientFactory.Instance, "Drapper.Databases.Tests.MySql.json"))
        {            
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}