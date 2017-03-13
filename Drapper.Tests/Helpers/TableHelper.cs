// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.09 (21:44)
// modified     : 2017-02-09 (22:41)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System;
using System.Linq;
using static Drapper.Tests.Helpers.CommanderHelper;

#endregion

namespace Drapper.Tests.Helpers
{
    public static class TableHelper
    {
        private static object _lock = new object();
        private static IDbCommander _commander = CreateCommander();
        public static void CreateTable(string tableName)
        {
            _commander.Execute(new { tableName });
        }

        public static void CreatePocoTable()
        {
            _commander.Execute();
        }

        public static void CreateBulkInsertTable()
        {
            _commander.Execute();
        }

        public static bool TableExists(string name)
        {
            return _commander.Query<bool>(new { name }).SingleOrDefault();
        }
        
        public static bool IsStale()
        {
            var modified = _commander.Query<DateTime>().SingleOrDefault();
            return modified.Date != DateTime.UtcNow.Date;
        }

        public static bool IsConsistent()
        {
            var result = _commander.Query<int>().SingleOrDefault();
            return result == 42;
        }

        public static void ClearAndPopulate()
        {
            // lock until complete
            lock (_lock)
            {
                ClearPocoTable();
                PopulatePocoTable();
            }
        }

        private static void ClearPocoTable()
        {
            _commander.Execute();
        }

        private static void PopulatePocoTable()
        {            
            // 42 entries, 
            for (var i = 1; i < 43; i++)
            {    
                var entry = new
                {
                    Name = i,
                    Value = i + 14,
                    Modified = DateTime.UtcNow
                };

                _commander.Execute(entry);
            }

            
        }
    }
}