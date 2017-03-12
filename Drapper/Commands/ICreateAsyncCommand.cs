// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Drapper.Commands
{
    /// <summary>
    /// Represents an operations which persists a  new object to  the underlying backing store using the async call pattern.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IDisposable" />
    public interface ICreateAsyncCommand<T> : IDisposable
    {      
        /// <summary>
        /// Persists objects using an asynchronous method signature.
        /// <para>
        /// This method will support persistence of both POCO's and primitive types. To persist object graphs 
        /// use the synchronous method.         
        /// </para>
        /// </summary>
        /// <typeparam name="T">Any type of object. Both reference & value types are supported.</typeparam> 
        /// <param name="model">The model. This can be a POCO or primitive types</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<T> CreateAsync(T model, CancellationToken cancellationToken = default(CancellationToken));
    }
}
