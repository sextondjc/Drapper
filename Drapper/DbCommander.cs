// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Dapper;
using Drapper.Configuration;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;

namespace Drapper
{
    public sealed partial class DbCommander : IDbCommander
    {
        private readonly IDbConnector _connector;
        private readonly ICommandReader _reader;

        /// <summary>
        /// Initializes a new instance of <see cref="DbCommander"/>
        /// </summary>
        /// <param name="connector">An <see cref="IDbConnector"/> to create connections to the underlying data store.</param>
        /// <param name="reader">An <see cref="ICommandReader"/> which parses a <see cref="CommandSetting"/>
        /// to return <see cref="CommandDefinition"/></param>.
        public DbCommander
            (
            IDbConnector connector,
            ICommandReader reader
            )
        {
            _connector = connector;
            _reader = reader;
        }

        [Browsable(false)]
        private CommandDefinition GetCommandDefinition(
            CommandSetting definition,
            object parameters = null,
            IDbTransaction transaction = null,
            CancellationToken cancellationToken = default(CancellationToken)) => new CommandDefinition(
                commandText: definition.CommandText,
                parameters: parameters,
                transaction: transaction,
                commandTimeout: definition.CommandTimeout,
                commandType: definition.CommandType,
                flags: definition.Flags,
                cancellationToken: cancellationToken);

        [Browsable(false)]
        private Type GetCallerType()
        {
            var frame = new StackFrame(2);
            var caller = frame.GetMethod();
            return caller.DeclaringType;
        }
        
        [Browsable(false)]
        private Type GetAsyncCallerType()
        {
            // not the *most* reliable. 
            // async calls don't follow the more vanilla stack approach that sync 
            // code does. aside from that, this is really a bastardization of 
            // the sync version above which itself relies on System.Diagnostics. 
            // not ideal to have that namespace in production code. 
            var frame = new StackFrame(6);
            var caller = frame.GetMethod();
            return caller.DeclaringType;
        }

        public void Dispose()
        {            
        }
    }
}
