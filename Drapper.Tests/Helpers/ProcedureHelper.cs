// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.10 (01:53)
// modified     : 2017-02-19 (22:10)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System.Threading.Tasks;

#endregion

namespace Drapper.Tests.Helpers
{
    public static class ProcedureHelper
    {
        private static async Task CreateTableCreatorProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                await commander.ExecuteAsync(0, typeof (ProcedureHelper));
            }
        }

        private static async Task CreateIdentityTesterProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                await commander.ExecuteAsync(0, typeof (ProcedureHelper));
            }
        }

        private static async Task CreateBulkInsertProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                await commander.ExecuteAsync(0, typeof (ProcedureHelper));
            }
        }
    }
}