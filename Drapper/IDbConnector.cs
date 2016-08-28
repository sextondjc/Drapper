// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration;
using System;
using System.Data;

namespace Drapper
{
    /// <summary>
    /// Used to create database connections against an underlying data store.
    /// </summary>
    public interface IDbConnector
    {
        /// <summary>
        /// Creates the database connection.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IDbConnection CreateDbConnection(Type type);

        /// <summary>
        /// Creates a database connection from a <see cref="CommandSetting"/>
        /// </summary>
        /// <param name="type"></param>
        /// <param name="commandSetting"></param>
        /// <returns></returns>
        IDbConnection CreateDbConnection(Type type, CommandSetting commandSetting);        
    }
}
