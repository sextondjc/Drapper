// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:17)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System;
using System.Data;
using Drapper.Configuration;

#endregion

namespace Drapper
{
    /// <summary>
    ///     Used to create database connections against an underlying data store.
    /// </summary>
    public interface IDbConnector
    {
        /// <summary>
        ///     Creates the database connection.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IDbConnection CreateDbConnection(Type type);

        /// <summary>
        ///     Creates a database connection from a <see cref="CommandSetting" />
        /// </summary>
        /// <param name="type"></param>
        /// <param name="commandSetting"></param>
        /// <returns></returns>
        IDbConnection CreateDbConnection(
            Type type,
            CommandSetting commandSetting);
    }
}