//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.26 (22:15)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Data.SqlClient;
using Drapper.Databases.Integration.Tests;
using Drapper.SqlServer.Tests.Setup;
using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerQueryFixture : QueryFixture
    {
        public SqlServerQueryFixture() : base(CommanderHelper.CreateCommander<Query>(() => SqlClientFactory.Instance, "Drapper.Databases.Tests.SqlServer.json"))
        {
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}