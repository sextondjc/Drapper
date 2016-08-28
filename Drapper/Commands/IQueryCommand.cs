// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;

namespace Drapper.Commands
{
    /// <summary>
    /// Helper interface for retrieving objects. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IDisposable" />
    public interface IRetrieveCommand<T> : IDisposable
    {
        /// <summary>
        /// Retrieves all.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> RetrieveAll();
    }
}
