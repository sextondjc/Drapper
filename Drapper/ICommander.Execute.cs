// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:51)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System;
using System.Runtime.CompilerServices;
using System.Transactions;

#endregion

namespace Drapper
{
    /// <inheritdoc />
    /// <summary>
    ///     Basically breaks down into two distinct operations for mutating data/retrieving data
    /// </summary>
    public partial interface ICommander<TRepository>
    {
        /// <summary>
        ///     Executes an arbitrary command against the underlying data store.
        /// </summary>
        /// <typeparam name="T"></typeparam>        
        /// <param name="method">The method.</param>
        /// <returns></returns>
        bool Execute<T>([CallerMemberName] string method = null);

        /// <summary>
        ///     Executes a potentially state changing operation against the underlying data store (create/update/delete)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">The model.</param>        
        /// <param name="method">The method.</param>
        /// <returns></returns>
        bool Execute<T>(T model, [CallerMemberName] string method = null);

        /// <summary>
        ///     Executes any number of potentially state changing operations against an underlying data store.
        ///     This method will escalate to a distributed transaction if the operations spans more than one
        ///     database.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The map.</param>
        /// <param name="scopeOption">The <see cref="TransactionScopeOption"/> applied to the function.</param>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        TResult Execute<TResult>(Func<TResult> map, TransactionScopeOption scopeOption = TransactionScopeOption.Suppress, [CallerMemberName] string method = null);
    }
}