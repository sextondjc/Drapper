// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Drapper.Commands
{
    /// <summary>
    /// Represents a delete operation on the underlying storage. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IDisposable" />
    public interface IDeleteAsyncCommand<T> : IDisposable
    {
        /// <summary>
        /// Deletes the object using the asynchronous pattern. 
        /// </summary>
        /// <param name="model">The model. This can be a POCO or primitive.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<T> DeleteAsync(T model, CancellationToken cancellationToken = default(CancellationToken));
    }
}
