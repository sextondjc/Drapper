//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Dapper;

namespace Drapper.Databases
{
    public partial class DatabaseCommander<TRepository>
    {
        public IEnumerable<TResult> Query<TResult>(object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                return connection.Query<TResult>(command);
            }
        }

        public IEnumerable<TResult> Query<T1, TResult>(object parameters = null,
            [CallerMemberName] string method = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> Query<T1, T2, TResult>(Func<T1, T2, TResult> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                return connection.Query(
                    setting.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: setting.Split,
                    commandTimeout: setting.CommandTimeout,
                    commandType: setting.CommandType);
            }
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> Query<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                return connection.Query(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: setting.Split,
                    commandTimeout: command.CommandTimeout,
                    commandType: command.CommandType);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> map,
            object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                return connection.Query(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: setting.Split,
                    commandTimeout: command.CommandTimeout,
                    commandType: command.CommandType);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> map,
            object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                return connection.Query(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: setting.Split,
                    commandTimeout: command.CommandTimeout,
                    commandType: command.CommandType);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> map,
            object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                return connection.Query(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: setting.Split,
                    commandTimeout: command.CommandTimeout,
                    commandType: command.CommandType);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                return connection.Query(
                    command.CommandText,
                    map,
                    buffered: command.Buffered,
                    param: command.Parameters,
                    splitOn: setting.Split,
                    commandTimeout: command.CommandTimeout,
                    commandType: command.CommandType);
            }
        }

        public IEnumerable<TResult> Query<T1, TResult>(Func<IEnumerable<T1>, IEnumerable<TResult>> map,
            object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                // pass control back to the mapping function. 
                return map(t1);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<TResult>> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                // pass control back to the mapping function. 
                return map(t1, t2);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<TResult>> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<TResult>> map,
            object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>,
                IEnumerable<TResult>> map, object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<TResult>> map, object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<TResult>> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<TResult>> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<TResult>> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<TResult>> map,
            object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                var t10 = reader.Read<T10>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>,
                IEnumerable<TResult>> map, object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                var t10 = reader.Read<T10>();
                var t11 = reader.Read<T11>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>,
                IEnumerable<TResult>> map, object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                var t10 = reader.Read<T10>();
                var t11 = reader.Read<T11>();
                var t12 = reader.Read<T12>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>,
                IEnumerable<T13>, IEnumerable<TResult>> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                var t10 = reader.Read<T10>();
                var t11 = reader.Read<T11>();
                var t12 = reader.Read<T12>();
                var t13 = reader.Read<T13>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>,
                IEnumerable<T13>, IEnumerable<T14>, IEnumerable<TResult>> map, object parameters = null,
            [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                var t10 = reader.Read<T10>();
                var t11 = reader.Read<T11>();
                var t12 = reader.Read<T12>();
                var t13 = reader.Read<T13>();
                var t14 = reader.Read<T14>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
            }
        }

        public IEnumerable<TResult> Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>,
                IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>,
                IEnumerable<T13>, IEnumerable<T14>, IEnumerable<T15>, IEnumerable<TResult>> map,
            object parameters = null, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                var t10 = reader.Read<T10>();
                var t11 = reader.Read<T11>();
                var t12 = reader.Read<T12>();
                var t13 = reader.Read<T13>();
                var t14 = reader.Read<T14>();
                var t15 = reader.Read<T15>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
            }
        }

        public IEnumerable<TResult>
            Query<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                Func<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>,
                    IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>,
                    IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, IEnumerable<T15>,
                    IEnumerable<T16>, IEnumerable<TResult>> map, object parameters = null,
                [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            var command = GetCommandDefinition(setting, parameters);
            using (var connection = _connector.CreateConnection(setting))
            {
                var reader = connection.QueryMultiple(command);
                var t1 = reader.Read<T1>();
                var t2 = reader.Read<T2>();
                var t3 = reader.Read<T3>();
                var t4 = reader.Read<T4>();
                var t5 = reader.Read<T5>();
                var t6 = reader.Read<T6>();
                var t7 = reader.Read<T7>();
                var t8 = reader.Read<T8>();
                var t9 = reader.Read<T9>();
                var t10 = reader.Read<T10>();
                var t11 = reader.Read<T11>();
                var t12 = reader.Read<T12>();
                var t13 = reader.Read<T13>();
                var t14 = reader.Read<T14>();
                var t15 = reader.Read<T15>();
                var t16 = reader.Read<T16>();
                // pass control back to the mapping function. 
                return map(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
            }
        }
    }
}