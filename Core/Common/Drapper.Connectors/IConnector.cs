﻿//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Settings;

namespace Drapper.Connectors
{
    /// <summary>
    /// Defines a contract for all connectors. The contract depends 
    /// on the type of <see cref="ICommandSetting"/> defined for
    /// this connection to use.
    /// </summary>
    /// <typeparam name="TConnection">The connection to be returned.</typeparam>
    /// <typeparam name="TCommandSetting"></typeparam>
    public interface IConnector<out TConnection, in TCommandSetting> where TCommandSetting : ICommandSetting
    {
        TConnection CreateConnection(TCommandSetting commandSetting);
    }
}