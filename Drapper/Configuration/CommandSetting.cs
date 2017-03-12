// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Dapper;
using System.Data;

namespace Drapper.Configuration
{
    /// <summary>
    /// This class exists to support the separation of a
    /// <see cref="Dapper.CommandDefinition" /> from the 
    /// <see cref="IDbCommander"/>.
    /// </summary>
    public class CommandSetting
    {
        /// <summary>
        /// Gets or sets the connection string setting.
        /// </summary>
        /// <value>
        /// The connection string setting.
        /// </value>
        public ConnectionStringSetting ConnectionString { get; set; }

        /// <summary>
        /// Used for Dapper multimap splits. 
        /// </summary>
        public string Split { get; set; } = "Id";

        /// <summary>
        /// The command text to be executed against the SQL database.
        /// </summary>
        public string CommandText { get; set; }

        /// <summary>
        /// The <see cref="System.Data.IDbCommand.CommandTimeout"/>. Defaults to 30.        
        /// </summary>
        public int CommandTimeout { get; set; } = 30;

        /// <summary>
        /// The <see cref="System.Data.CommandType"/>. Defaults to <see cref="CommandType.Text"/>.
        /// </summary>
        public CommandType CommandType { get; set; } = CommandType.Text;

        /// <summary>
        /// The <see cref="Dapper.CommandFlags"/>. Defaults to <see cref="CommandFlags.None"/>
        /// </summary>
        public CommandFlags Flags { get; set; } = CommandFlags.None;

        /// <summary>
        /// Gets or sets the isolation level used by a transaction. 
        /// Defaults to <see cref="IsolationLevel.Serializable"/>
        /// </summary>        
        public IsolationLevel IsolationLevel { get; set; } = IsolationLevel.Serializable;
    }
}
