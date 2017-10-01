//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.30 (00:09)
//  modified     : 2017.10.01 (20:41)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Commanders.Databases.Integration.Tests;
using Drapper.MySql.Integration.Tests.Setup;
using Drapper.Tests.Common;

namespace Drapper.MySql.Integration.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MySqlExecuteFixture : ExecuteFixture
    {
        public MySqlExecuteFixture() : base(CommanderHelper.UseMySql<Execute>())
        {
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}