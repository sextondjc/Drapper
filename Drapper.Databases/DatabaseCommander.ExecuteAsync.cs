using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Drapper.Databases
{
    public partial class DatabaseCommander : ICommander
    {
        public Task<bool> ExecuteAsync<T>(Type type, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExecuteAsync<T>(T model, Type type, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> ExecuteAsync<TResult>(Func<TResult> map, CancellationToken cancellationToken = default(CancellationToken), [CallerMemberName] string method = null)
        {
            throw new NotImplementedException();
        }
    }
}
