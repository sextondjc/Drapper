//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

#region

using System.Data;
using Drapper.Settings.Databases;

#endregion

namespace Drapper.Connectors.Databases
{
    /// <summary>
    ///     Used to create database connections against an underlying data store.
    /// </summary>
    public interface IDatabaseConnector : IConnector<IDbConnection, DatabaseCommandSetting>
    {
    }
}