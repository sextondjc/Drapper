//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (23:20)
//  modified     : 2017.10.01 (20:41)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Settings.Databases;
using MySql.Data.MySqlClient;

namespace Drapper.Connectors.Databases.MySql
{
    public class MySqlDatabaseConnector : DatabaseConnector
    {
        public MySqlDatabaseConnector(IDatabaseCommanderSettings settings)
            : base(settings, () => MySqlClientFactory.Instance)
        {
        }
    }
}