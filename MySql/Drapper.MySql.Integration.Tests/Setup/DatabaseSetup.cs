//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.30 (00:09)
//  modified     : 2017.10.01 (20:41)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Linq;
using Drapper.Tests.Common;

namespace Drapper.MySql.Integration.Tests.Setup
{
    public class DatabaseSetup
    {
        private readonly ICommander<DatabaseSetup> _commander;
        private object _lock = new object();

        public DatabaseSetup()
        {
            _commander = CommanderHelper.UseMySql<DatabaseSetup>();
        }

        public void Setup(string name = "drapper_my_sql")
        {
            Console.WriteLine($"Running environment setup checks against databse '{name}'.");
            if (!DatabaseExists(name))
            {
                Console.WriteLine($"{name} doesn't exist. Attempting to create.");
                CreateDatabase(name);
            }

            if (!TableExists("Poco"))
            {
                Console.WriteLine("Poco table doesn't exist. Attempting to create.");
                CreatePocoTable();
            }

            //if (!TableExists("BulkInsert"))
            //{
            //    Console.WriteLine("BulkInsert table doesn't exist. Attempting to create.");
            //    CreateBulkInsertTable();
            //}

            if (!TableCreatorExists())
            {
                Console.WriteLine("Table creator procedure doesn't exist. Attempting to create.");
                CreateTableCreatorProcedure();
            }

            //if (!IdentityTesterExists())
            //{
            //    Console.WriteLine("Identity tester procedure doesn't exist. Attempting to create.");
            //    CreateIdentityTesterProcedure();
            //}

            //if (!BulkInsertProcedureExists())
            //{
            //    Console.WriteLine("Bulk insert tester procedure doesn't exist. Attempting to create.");
            //    CreateBulkInsertProcedure();
            //}

            //if (!BulkInsertAndReturnProcedureExists())
            //{
            //    Console.WriteLine("Bulk insert and return tester procedure doesn't exist. Attempting to create.");
            //    CreateBulkInsertAndReturnProcedure();
            //}

            if (IsStale())
            {
                Console.WriteLine("Data in the Poco table is stale. Attempting to refresh.");
                ClearAndPopulate();
            }

            if (!IsConsistent())
            {
                Console.WriteLine("Data in the Poco table is stale. Attempting to refresh.");
                ClearAndPopulate();
            }

            CreateDistributedTransactionTable();

            Console.WriteLine("Finished setting database up. Let the games begin!");
        }

        #region / database /

        private void CreateDatabase(string name = "drapper_my_sql")
        {
            // using Query to skip transactionality. 
            _commander.Query<string>(new {name});
            Console.WriteLine($"{name} created!");
        }

        private void DropDatabase(string name = "drapper_my_sql")
        {
            _commander.Execute(new {name});
            Console.WriteLine($"{name} dropped!");
        }

        private bool DatabaseExists(string name = "drapper_my_sql")
        {
            return _commander.Query<bool>(new {name}).SingleOrDefault();
        }

        private void DropAllTables(string name)
        {
            _commander.Execute(new {name});
        }

        #endregion

        #region / tables / 

        private void CreateDistributedTransactionTable()
        {
            const string tableName = "DistributedTransaction";
            Console.WriteLine("Creating DistributedTransactionTable");
            CreateTable(tableName);
        }

        private void CreateTable(string tableName)
        {
            _commander.Execute(new {tableName});
        }

        private void CreatePocoTable()
        {
            _commander.Execute<bool>();
        }

        private void CreateBulkInsertTable()
        {
            _commander.Execute<bool>();
        }

        private bool TableExists(string name)
        {
            return _commander.Query<bool>(new {name}).SingleOrDefault();
        }

        private bool IsStale()
        {
            var modified = _commander.Query<DateTime>().SingleOrDefault();
            return modified.Date != DateTime.UtcNow.Date;
        }

        private bool IsConsistent()
        {
            var result = _commander.Query<int>().SingleOrDefault();
            return result == 150;
        }

        private void ClearAndPopulate()
        {
            // lock until complete
            lock (_lock)
            {
                ClearPocoTable();
                PopulatePocoTable();
            }
        }

        private void ClearPocoTable()
        {
            _commander.Execute<bool>();
        }

        private void PopulatePocoTable()
        {
            // 150 entries, 
            for (var i = 1; i < 151; i++)
            {
                var entry = new
                {
                    Id = i,
                    Name = i,
                    Value = i + 14,
                    Modified = DateTime.UtcNow
                };

                _commander.Execute(entry);
            }
        }

        #endregion

        #region / procedures / 

        private bool TableCreatorExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        private void CreateTableCreatorProcedure()
        {
            _commander.Execute<bool>();
        }

        private bool IdentityTesterExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        private void CreateIdentityTesterProcedure()
        {
            _commander.Execute<bool>();
        }

        private bool BulkInsertProcedureExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        private bool BulkInsertAndReturnProcedureExists()
        {
            return _commander.Query<bool>().SingleOrDefault();
        }

        private void CreateBulkInsertProcedure()
        {
            _commander.Execute<bool>();
        }

        private void CreateBulkInsertAndReturnProcedure()
        {
            _commander.Execute<bool>();
        }

        #endregion
    }
}