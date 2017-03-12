// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drapper.Commands
{
    /// <summary>
    /// Queries the underlying storage asynchronously.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IDisposable" />
    public interface IQueryAsyncCommand<T> : IDisposable
    {
        /// <summary>
        /// Retrieves asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<IEnumerable<T>> RetrieveAllAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
