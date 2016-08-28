// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Runtime.CompilerServices;

namespace Drapper
{
    /// <summary>
    /// Basically breaks down into two distinct operations for mutating data/retrieving data
    /// </summary>
    public partial interface IDbCommander : IDisposable
    {
        /// <summary>
        /// Executes a potentially state changing operation against the underlying data store (create/update/delete)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">The model.</param>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        bool Execute<T>(T model, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Executes any number of potentially state changing operations against an underlying data store. 
        /// This method will escalate to a distributed transaction if the operations spans more than one 
        /// database.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The map.</param>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        TResult Execute<TResult>(Func<TResult> map, Type type = null, [CallerMemberName] string method = null);
    }
}
