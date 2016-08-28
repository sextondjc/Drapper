// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;

namespace Drapper.Commands
{
    /// <summary>
    /// Represents an operation which persists a new object to an underlying store.
    /// </summary>
    public interface ICreateCommand<T> : IDisposable
    {
        /// <summary>
        /// Persists an object to the underlying store.
        /// </summary>
        /// <param name="model">The model. This can be a POCO or primitive type..</param>
        /// <returns></returns>
        T Create(T model);
    }
}
