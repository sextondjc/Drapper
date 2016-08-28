// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Drapper
{
    /// <summary>
    /// Basically breaks down into two distinct operations for mutating data/retrieving data
    /// </summary>
    public partial interface IDbCommander : IDisposable
    {
        #region / query /

        /// <summary>
        /// Query the data source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(
            object parameters = null, 
            Type type = null, 
            [CallerMemberName] string method = null);

        #endregion

        #region / multimap /

        /// <summary>
        /// Use a multimap query with two generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">Mapping predicate used to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, TResult>(Func<T1, T2, TResult> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multimap query with three generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multimap query with four generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multimap query with five generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multimap query with six generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multimap query with seven generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        #endregion

        #region / multiple /

        /// <summary>
        /// Use a multiple query with a single generic input.
        /// </summary>
        /// <typeparam name="T1">The input type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, TResult>(Func<IEnumerable<T1>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with two generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with three generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with four generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with five generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with six generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with seven generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with eight generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>       
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with nine generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with ten generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>
        /// <typeparam name="T10">The tenth type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with eleven generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>
        /// <typeparam name="T10">The tenth type.</typeparam>
        /// <typeparam name="T11">The eleventh type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with twelve generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>
        /// <typeparam name="T10">The tenth type.</typeparam>
        /// <typeparam name="T11">The eleventh type.</typeparam>
        /// <typeparam name="T12">The twelfth type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with thirteen generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>
        /// <typeparam name="T10">The tenth type.</typeparam>
        /// <typeparam name="T11">The eleventh type.</typeparam>
        /// <typeparam name="T12">The twelfth type.</typeparam>
        /// <typeparam name="T13">The thirteenth type.</typeparam>        
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with fourteen generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>
        /// <typeparam name="T10">The tenth type.</typeparam>
        /// <typeparam name="T11">The eleventh type.</typeparam>
        /// <typeparam name="T12">The twelfth type.</typeparam>
        /// <typeparam name="T13">The thirteenth type.</typeparam>
        /// <typeparam name="T14">The fourteenth type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with fifteen generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>
        /// <typeparam name="T10">The tenth type.</typeparam>
        /// <typeparam name="T11">The eleventh type.</typeparam>
        /// <typeparam name="T12">The twelfth type.</typeparam>
        /// <typeparam name="T13">The thirteenth type.</typeparam>
        /// <typeparam name="T14">The fourteenth type.</typeparam>
        /// <typeparam name="T15">The fifteenth type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, IEnumerable<T15>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        /// <summary>
        /// Use a multiple query with sixteen generic inputs.
        /// </summary>
        /// <typeparam name="T1">The first type.</typeparam>
        /// <typeparam name="T2">The second type.</typeparam>
        /// <typeparam name="T3">The third type.</typeparam>
        /// <typeparam name="T4">The fourth type.</typeparam>
        /// <typeparam name="T5">The fifth type.</typeparam>
        /// <typeparam name="T6">The sixth type.</typeparam>
        /// <typeparam name="T7">The seventh type.</typeparam>
        /// <typeparam name="T8">The eighth type.</typeparam>
        /// <typeparam name="T9">The ninth type.</typeparam>
        /// <typeparam name="T10">The tenth type.</typeparam>
        /// <typeparam name="T11">The eleventh type.</typeparam>
        /// <typeparam name="T12">The twelfth type.</typeparam>
        /// <typeparam name="T13">The thirteenth type.</typeparam>
        /// <typeparam name="T14">The fourteenth type.</typeparam>
        /// <typeparam name="T15">The fifteenth type.</typeparam>
        /// <typeparam name="T16">The sixteenth.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="map">The mapping func to use to compose the result type.</param>
        /// <param name="parameters">Optional parameters to pass to the query.</param>
        /// <param name="type">Optionally pass the caller type to explicity specify type lookup.</param>
        /// <param name="method">Optionally pass a method name to use as the key to finding a definition entry.</param>
        /// <returns></returns>
        IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, IEnumerable<T15>, IEnumerable<T16>, IEnumerable<TResult>> map, object parameters = null, Type type = null, [CallerMemberName] string method = null);

        #endregion        
    }
}
