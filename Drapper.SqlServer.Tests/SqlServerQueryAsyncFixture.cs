//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (15:51)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerQueryAsyncFixture : QueryAsyncFixture
    {
        public SqlServerQueryAsyncFixture() : base(CommanderHelper.UseSqlServer<QueryAsync>())
        {
        }
    }
}