// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Dapper;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Drapper
{
    public sealed partial class DbCommander : IDbCommander
    {
        public async Task<IEnumerable<T>> QueryAsync<T>(
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            var connection = _connector.CreateDbConnection(type, definition);
            return await connection.QueryAsync<T>(command);
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, TResult>(
            Func<T1, T2, TResult> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            var connection = _connector.CreateDbConnection(type, definition);
            return await connection.QueryAsync(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: definition.Split,
                    commandTimeout: definition.CommandTimeout,
                    commandType: definition.CommandType);
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, TResult>(
            Func<T1, T2, T3, TResult> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            var connection = _connector.CreateDbConnection(type, definition);
            return await connection.QueryAsync(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: definition.Split,
                    commandTimeout: definition.CommandTimeout,
                    commandType: definition.CommandType);
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, TResult>(
            Func<T1, T2, T3, T4, TResult> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            var connection = _connector.CreateDbConnection(type, definition);
            return await connection.QueryAsync(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: definition.Split,
                    commandTimeout: definition.CommandTimeout,
                    commandType: definition.CommandType);
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, TResult>(
            Func<T1, T2, T3, T4, T5, TResult> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            var connection = _connector.CreateDbConnection(type, definition);
            return await connection.QueryAsync(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: definition.Split,
                    commandTimeout: definition.CommandTimeout,
                    commandType: definition.CommandType);
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, TResult> map,
            object parameters = null, Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            var connection = _connector.CreateDbConnection(type, definition);
            return await connection.QueryAsync(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: definition.Split,
                    commandTimeout: definition.CommandTimeout,
                    commandType: definition.CommandType);
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            var connection = _connector.CreateDbConnection(type, definition);
            return await connection.QueryAsync(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: definition.Split,
                    commandTimeout: definition.CommandTimeout,
                    commandType: definition.CommandType);
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, TResult>(
            Func<IEnumerable<T1>, IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();

                // pass control back to the mapping function. 
                return map(t1);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();

                // pass control back to the mapping function. 
                return map(t1, t2);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<T10>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();
                var t10 = await reader.ReadAsync<T10>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<T10>,
                IEnumerable<T11>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();
                var t10 = await reader.ReadAsync<T10>();
                var t11 = await reader.ReadAsync<T11>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<T10>,
                IEnumerable<T11>,
                IEnumerable<T12>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();
                var t10 = await reader.ReadAsync<T10>();
                var t11 = await reader.ReadAsync<T11>();
                var t12 = await reader.ReadAsync<T12>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<T10>,
                IEnumerable<T11>,
                IEnumerable<T12>,
                IEnumerable<T13>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();
                var t10 = await reader.ReadAsync<T10>();
                var t11 = await reader.ReadAsync<T11>();
                var t12 = await reader.ReadAsync<T12>();
                var t13 = await reader.ReadAsync<T13>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<T10>,
                IEnumerable<T11>,
                IEnumerable<T12>,
                IEnumerable<T13>,
                IEnumerable<T14>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();
                var t10 = await reader.ReadAsync<T10>();
                var t11 = await reader.ReadAsync<T11>();
                var t12 = await reader.ReadAsync<T12>();
                var t13 = await reader.ReadAsync<T13>();
                var t14 = await reader.ReadAsync<T14>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<T10>,
                IEnumerable<T11>,
                IEnumerable<T12>,
                IEnumerable<T13>,
                IEnumerable<T14>,
                IEnumerable<T15>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();
                var t10 = await reader.ReadAsync<T10>();
                var t11 = await reader.ReadAsync<T11>();
                var t12 = await reader.ReadAsync<T12>();
                var t13 = await reader.ReadAsync<T13>();
                var t14 = await reader.ReadAsync<T14>();
                var t15 = await reader.ReadAsync<T15>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
            }
        }

        public async Task<IEnumerable<TResult>> QueryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            Func<IEnumerable<T1>,
                IEnumerable<T2>,
                IEnumerable<T3>,
                IEnumerable<T4>,
                IEnumerable<T5>,
                IEnumerable<T6>,
                IEnumerable<T7>,
                IEnumerable<T8>,
                IEnumerable<T9>,
                IEnumerable<T10>,
                IEnumerable<T11>,
                IEnumerable<T12>,
                IEnumerable<T13>,
                IEnumerable<T14>,
                IEnumerable<T15>,
                IEnumerable<T16>,
                IEnumerable<TResult>> map,
            object parameters = null,
            Type type = null,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            var command = GetCommandDefinition(definition, parameters, cancellationToken: cancellationToken);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                var reader = await connection.QueryMultipleAsync(command);
                var t1 = await reader.ReadAsync<T1>();
                var t2 = await reader.ReadAsync<T2>();
                var t3 = await reader.ReadAsync<T3>();
                var t4 = await reader.ReadAsync<T4>();
                var t5 = await reader.ReadAsync<T5>();
                var t6 = await reader.ReadAsync<T6>();
                var t7 = await reader.ReadAsync<T7>();
                var t8 = await reader.ReadAsync<T8>();
                var t9 = await reader.ReadAsync<T9>();
                var t10 = await reader.ReadAsync<T10>();
                var t11 = await reader.ReadAsync<T11>();
                var t12 = await reader.ReadAsync<T12>();
                var t13 = await reader.ReadAsync<T13>();
                var t14 = await reader.ReadAsync<T14>();
                var t15 = await reader.ReadAsync<T15>();
                var t16 = await reader.ReadAsync<T16>();

                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
            }
        }
    }
}
