// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.10 (01:53)
// modified     : 2017-02-19 (22:10)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System.Linq;
using System.Threading.Tasks;
using static Drapper.Tests.Helpers.CommanderHelper;

#endregion

namespace Drapper.Tests.Helpers
{
    public static class ProcedureHelper
    {
        private static object _lock = new object();
        private static IDbCommander _commander = CreateCommander();

        public static bool TableCreatorExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        public static void CreateTableCreatorProcedure()
        {
            _commander.Execute();
        }

        public static bool IdentityTesterExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        public static void CreateIdentityTesterProcedure()
        {
            _commander.Execute();
        }

        public static bool BulkInsertProcedureExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        public static bool BulkInsertAndReturnProcedureExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        public static void CreateBulkInsertProcedure()
        {
            _commander.Execute(type:typeof(ProcedureHelper));
        }

        public static void CreateBulkInsertAndReturnProcedure()
        {
            _commander.Execute(type: typeof(ProcedureHelper));
        }        
    }
}