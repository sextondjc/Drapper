// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.09 (21:43)
// modified     : 2017-02-10 (01:34)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================
#region

using System.Linq;
using static System.Console;

#endregion

namespace Drapper.Tests.Helpers
{
    public static class DatabaseHelper
    {
        // create a new database called "Drapper"
        public static void CreateDatabase(string name = "Drapper")
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                // using Query to skip transactionality. 
                commander.Query<string>(new {name});
            }

            WriteLine($"{name} created!");
        }

        public static void DropDatabase(string name = "Drapper")
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                commander.Execute(new {name});
            }

            WriteLine($"{name} dropped!");
        }

        public static bool DatabaseExists(string name = "Drapper")
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                return commander.Query<bool>(new {name}).SingleOrDefault();
            }
        }

        public static void DropAllTables(string name)
        {
            using (var commander = CommanderHelper.CreateCommander())
            {
                commander.Execute(new {name});
            }
        }
    }
}