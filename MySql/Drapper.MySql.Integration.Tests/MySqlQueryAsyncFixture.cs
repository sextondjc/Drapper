//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (15:51)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Data.SqlClient;
using Drapper.Databases.Integration.Tests;
using Drapper.Tests.Common;

namespace Drapper.MySql.Integration.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MySqlQueryAsyncFixture : QueryAsyncFixture
    {
        public MySqlQueryAsyncFixture() : base(CommanderHelper.CreateCommander<QueryAsync>(() => SqlClientFactory.Instance, "Drapper.Databases.Tests.MySql.json"))
        {
        }
    }
}