// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.09 (22:13)
// modified     : 2017-02-09 (23:04)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using static Drapper.Tests.Helpers.DatabaseHelper;
using static Drapper.Tests.Helpers.TableHelper;
using static System.Console;

#endregion

namespace Drapper.Tests.Helpers
{
    /// <summary>
    ///     Establishes that the environment is set up to allow tests to run.
    /// </summary>
    public static class EnvironmentHelper
    {
        public static void Setup(string name = "Drapper")
        {
            WriteLine($"Running environment setup checks against databse '{name}'.");
            if (!DatabaseExists(name))
            {
                WriteLine($"{name} doesn't exist. Attempting to create.");
                CreateDatabase(name);
            }

            if (!TableExists("Poco"))
            {
                WriteLine("Poco table doesn't exist. Attempting to create.");
                CreatePocoTable();
            }

            if (!TableCreatorExists())
            {
                WriteLine("Table creator procedure doesn't exist. Attempting to create.");
                CreateTableCreatorProcedure();
            }

            if (IsStale())
            {
                WriteLine("Data in the Poco table is stale. Attempting to refresh.");
                ClearAndPopulate();
            }

            if (!IsConsistent())
            {
                WriteLine("Data in the Poco table is stale. Attempting to refresh.");
                ClearAndPopulate();
            }
        }

        public static void Teardown(string name = "Drapper")
        {
            if (DatabaseExists(name))
            {
                DropDatabase(name);
            }
        }
    }
}