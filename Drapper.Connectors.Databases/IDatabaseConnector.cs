// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:17)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

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