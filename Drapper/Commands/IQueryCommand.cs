// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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
