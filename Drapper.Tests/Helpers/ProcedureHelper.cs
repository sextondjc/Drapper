using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drapper.Tests.Helpers
{
    public static class ProcedureHelper
    {
        public static void Build()
        {
            
        }



        private static async Task CreateTableCreatorProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                await commander.ExecuteAsync(0, typeof(ProcedureHelper));
            }
        }

        private static async Task CreateIdentityTesterProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                await commander.ExecuteAsync(0, typeof(ProcedureHelper));
            }
        }

        private static async Task CreateBulkInsertProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                await commander.ExecuteAsync(0, typeof(ProcedureHelper));
            }
        }
    }
}
