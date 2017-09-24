using System;
using System.Runtime.CompilerServices;

namespace Drapper.Databases
{
    public partial class DatabaseCommander : ICommander
    {

        public bool Execute<T>(Type type = null, [CallerMemberName] string method = null)
        {
            throw new NotImplementedException();
        }

        public bool Execute<T>(T model, Type type = null, [CallerMemberName] string method = null)
        {
            throw new NotImplementedException();
        }

        public TResult Execute<TResult>(Func<TResult> map, [CallerMemberName] string method = null)
        {
            throw new NotImplementedException();
        }


    }
}
