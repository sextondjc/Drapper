//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (21:36)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.SqlServer.Tests.Setup;
using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerExecuteAsyncFixture : ExecuteAsyncFixture
    {
        public SqlServerExecuteAsyncFixture() : base(CommanderHelper.UseSqlServer<ExecuteAsync>())
        {
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}