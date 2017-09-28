//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:53)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.SqlServer.Tests.Setup;
using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerExecuteFixture : ExecuteFixture
    {
        public SqlServerExecuteFixture() : base(CommanderHelper.UseSqlServer<Execute>())
        {
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}