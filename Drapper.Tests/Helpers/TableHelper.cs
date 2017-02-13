// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.09 (21:44)
// modified     : 2017-02-09 (22:41)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System;
using System.Collections.Generic;
using System.Linq;
using static Drapper.Tests.Helpers.CommanderHelper;

#endregion

namespace Drapper.Tests.Helpers
{
    public static class TableHelper
    {
        private static object _lock = new object();
        public static void CreateTable(string tableName)
        {
            using (var commander = CreateCommander())
            {
                commander.Execute(new {tableName});
            }
        }

        public static void CreatePocoTable()
        {
            using (var commander = CreateCommander())
            {
                commander.Execute(0);
            }
        }

        public static bool TableExists(string name)
        {
            using (var commander = CreateCommander())
            {
                return commander.Query<bool>(new {name}).SingleOrDefault();
            }
        }

        public static bool TableCreatorExists()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                return commander.Query<bool>().SingleOrDefault();
            }
        }

        public static void CreateTableCreatorProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                commander.Execute(0);
            }
        }

        public static bool IdentityTesterExists()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                return commander.Query<bool>().SingleOrDefault();
            }
        }

        public static void CreateIdentityTesterProcedure()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                commander.Execute(0);
            }
        }

        public static bool IsStale()
        {
            var modified = DateTime.MinValue;
            using (var commander = CreateCommander())
            {
                modified = commander.Query<DateTime>().SingleOrDefault();
            }

            return modified.Date != DateTime.UtcNow.Date;
        }

        public static bool IsConsistent()
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                var result = commander.Query<int>().SingleOrDefault();
                return result == 42;
            }
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

        public static void ClearPocoTable()
        {
            using (var commander = CreateCommander())
            {
                commander.Execute(0);
            }
        }

        public static void PopulatePocoTable()
        {
            var list = new List<dynamic>();

            // 42 entries, 
            for (var i = 1; i < 43; i++)
            {
                list.Add(new
                {
                    Name = i,
                    Value = i + 14,
                    Modified = DateTime.UtcNow
                });
            }

            using (var commander = CreateCommander())
            {
                commander.Execute(list);
            }
        }
    }
}