//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (19:23)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Drapper.Tests.Common;
using static System.Console;

namespace Drapper.SqlServer.Tests.Setup
{
    public class DatabaseSetup
    {
        private readonly ICommander<DatabaseSetup> _commander;
        private object _lock = new object();

        public DatabaseSetup()
        {
            _commander = CommanderHelper.UseSqlServer<DatabaseSetup>();
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

            if (!BulkInsertProcedureExists())
            {
                WriteLine("Bulk insert tester procedure doesn't exist. Attempting to create.");
                CreateBulkInsertProcedure();
            }

            if (!BulkInsertAndReturnProcedureExists())
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

            CreateDistributedTransactionTable();

            WriteLine("Finished setting database up. Let the games begin!");
        }

        #region / database /

        private void CreateDatabase(string name = "Drapper")
        {
            // using Query to skip transactionality. 
            _commander.Query<string>(new {name});
            WriteLine($"{name} created!");
        }

        private void DropDatabase(string name = "Drapper")
        {
            _commander.Execute(new {name});
            WriteLine($"{name} dropped!");
        }

        private bool DatabaseExists(string name = "Drapper")
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
            WriteLine("Creating DistributedTransactionTable");
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