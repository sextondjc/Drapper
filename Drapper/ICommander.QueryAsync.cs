// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:17)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Drapper
{
    /// <inheritdoc />
    /// <summary>
    ///     Basically breaks down into two distinct operations for mutating data/retrieving data
    /// </summary>
    public partial interface ICommander : IDisposable
    {
        /// <summary>
        ///     Queries the data source asynchronously.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The type.</param>
        /// <param name="parameters">The parameters to be passed to operation.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        Task<IEnumerable<T>> QueryAsync<T>(Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);
        
        Task<IEnumerable<TResult>> QueryAsync<T1, T2, TResult>(Func<T1, T2, TResult> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, TResult>(Func<IEnumerable<T1>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, IEnumerable<T15>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);

        Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, IEnumerable<T15>, IEnumerable<T16>, IEnumerable<TResult>> map, Type type, object parameters = null, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null);
    }
}