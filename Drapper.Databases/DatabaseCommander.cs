using System.ComponentModel;
using System.Data;
using System.Threading;
using Dapper;
using Drapper.Connectors.Databases;
using Drapper.Readers.Databases;
using Drapper.Settings.Databases;

namespace Drapper.Databases
{
    public partial class DatabaseCommander<TRepository> : ICommander<TRepository>
    {
        private readonly IDatabaseCommandReader _reader;
        private readonly IDatabaseConnector _connector;

        public DatabaseCommander(IDatabaseCommandReader reader, IDatabaseConnector connector)
        {            
            _reader = reader;
            _connector = connector;
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
                flags: (CommandFlags)setting.Flags,
                cancellationToken: cancellationToken);
        
        public void Dispose()
        {
            
        }

    }
}
