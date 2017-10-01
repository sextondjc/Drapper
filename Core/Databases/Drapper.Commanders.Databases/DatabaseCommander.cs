//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.ComponentModel;
using System.Data;
using System.Threading;
using Dapper;
using Drapper.Connectors.Databases;
using Drapper.Readers.Databases;
using Drapper.Settings.Databases;

namespace Drapper.Commanders.Databases
{
    public partial class DatabaseCommander<TRepository> : ICommander<TRepository>
    {
        private readonly IDatabaseConnector _connector;
        private readonly IDatabaseCommandReader _reader;

        public DatabaseCommander(IDatabaseCommandReader reader, IDatabaseConnector connector)
        {
            _reader = reader;
            _connector = connector;
        }

        public void Dispose()
        {
        }

        [Browsable(false)]
        private CommandDefinition GetCommandDefinition(
            DatabaseCommandSetting setting,
            object parameters = null,
            IDbTransaction transaction = null,
            CancellationToken cancellationToken = default(CancellationToken)) => new CommandDefinition(
            commandText: setting.CommandText,
            parameters: parameters,
            transaction: transaction,
            commandTimeout: setting.CommandTimeout,
            commandType: setting.CommandType,
            flags: (CommandFlags) setting.Flags,
            cancellationToken: cancellationToken);
    }
}