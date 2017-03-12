// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Drapper
{
    /// <summary>
    /// Basically breaks down into two distinct operations for mutating data/retrieving data
    /// </summary>
    public partial interface IDbCommander : IDisposable
    {
        /// <summary>
        /// Executes a potentially state changing operation asynchronously.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">The model.</param>
        /// <param name="type">The type.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        Task<bool> ExecuteAsync<T>(T model, Type type = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        /// <summary>
        /// Wraps a Func with a TransactionScope object. Doesn't handle async very well at all. Use at your own peril. 
        /// The "passing" test for this method is entirely synchronous in the map Func.         
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The map.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        Task<TResult> ExecuteAsync<TResult>(Func<TResult> map, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);        
    }
}
