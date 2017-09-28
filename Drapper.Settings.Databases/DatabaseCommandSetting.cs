using System;
using System.Data;
using static Drapper.Validation.Contract;

namespace Drapper.Settings.Databases
{
    /// <summary>
    /// This class exists to support the separation of a
    /// command from a commander.
    /// </summary>
    public class DatabaseCommandSetting : ICommandSetting
    {
        /// <summary>
        /// Used for aliasing connections
        /// </summary>
        public string ConnectionAlias { get; }

        /// <summary>
        /// Used for Dapper multimap splits. 
        /// </summary>
        public string Split { get; } 

        /// <summary>
        /// The command text to be executed against the SQL database.
        /// </summary>
        public string CommandText { get; }

        /// <summary>
        /// The <see cref="System.Data.IDbCommand.CommandTimeout"/>. Defaults to 30.        
        /// </summary>
        public int CommandTimeout { get; }

        /// <summary>
        /// The <see cref="System.Data.CommandType"/>. Defaults to Text.
        /// </summary>
        public CommandType CommandType { get; }

        /// <summary>
        /// The <see cref="CommandFlagSetting"/>. Defaults to <see cref="CommandFlagSetting.None"/>
        /// </summary>
        public CommandFlagSetting Flags { get; }

        /// <summary>
        /// Gets or sets the isolation level used by a transaction. 
        /// Defaults to <see><cref>IsolationLevel.Serializable</cref></see>
        /// </summary>        
        public IsolationLevel IsolationLevel { get; } 

        public DatabaseCommandSetting(
            string connectionAlias,
            string commandText,            
            CommandType commandType = CommandType.Text,
            int commandTimeout = 30,
            string split = "Id",
            CommandFlagSetting flags = CommandFlagSetting.None,
            IsolationLevel isolationLevel = IsolationLevel.Serializable
            )
        {
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(connectionAlias), nameof(connectionAlias));
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(commandText), nameof(commandText));

            ConnectionAlias = connectionAlias;
            CommandText = commandText;
            CommandType = commandType;
            CommandTimeout = commandTimeout;
            Split = split;
            Flags = flags;
            IsolationLevel = isolationLevel == 0 ? IsolationLevel.Serializable : isolationLevel;
        }
    }
}
