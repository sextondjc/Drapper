// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.09 (22:13)
// modified     : 2017-02-09 (23:04)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using static Drapper.Tests.Helpers.DatabaseHelper;
using static Drapper.Tests.Helpers.TableHelper;
using static Drapper.Tests.Helpers.ProcedureHelper;
using static System.Console;

#endregion

namespace Drapper.Tests.Helpers
{
    public class DatabaseFixture
    {

        public DatabaseFixture()
        {
            Setup();
        }

        public void Setup(string name = "Drapper")
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

            if (!TableExists("BulkInsert"))
            {
                WriteLine("BulkInsert table doesn't exist. Attempting to create.");
                CreateBulkInsertTable();
            }

            if (!TableCreatorExists())
            {
                WriteLine("Table creator procedure doesn't exist. Attempting to create.");
                CreateTableCreatorProcedure();
            }

            if (!IdentityTesterExists())
            {
                WriteLine("Identity tester procedure doesn't exist. Attempting to create.");
                CreateIdentityTesterProcedure();
            }

            if(!BulkInsertProcedureExists())
            {
                WriteLine("Bulk insert tester procedure doesn't exist. Attempting to create.");
                CreateBulkInsertProcedure();
            }

            if(!BulkInsertAndReturnProcedureExists())
            {
                WriteLine("Bulk insert and return tester procedure doesn't exist. Attempting to create.");
                CreateBulkInsertAndReturnProcedure();
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

        public void Teardown(string name = "Drapper")
        {
            if (DatabaseExists(name))
            {
                DropDatabase(name);
            }
        }
    }


}