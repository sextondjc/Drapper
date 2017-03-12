// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

using Dapper;
using Drapper.Configuration;
using System;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

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
            CommandSetting setting,
            object parameters = null,
            IDbTransaction transaction = null,
            CancellationToken cancellationToken = default(CancellationToken)) => new CommandDefinition(
                commandText: setting.CommandText,
                parameters: parameters,
                transaction: transaction,
                commandTimeout: setting.CommandTimeout,
                commandType: setting.CommandType,
                flags: setting.Flags,
                cancellationToken: cancellationToken);
        
        [Browsable(false)]
        private Type GetCallerType()
        {            
            return (new StackFrame(2)).GetMethod().DeclaringType;
        }
        
        [Browsable(false)]
        private Type GetAsyncCallerType()
        {
            // not the *most* reliable. 
            // async calls don't follow the more vanilla stack approach that sync 
            // code does. aside from that, this is really a bastardization of 
            // the sync version above which itself relies on System.Diagnostics. 
            // not ideal to have that namespace in production code. 
            return (new StackFrame(6)).GetMethod().DeclaringType;
        }

        public void Dispose()
        {            
        }
    }
}
