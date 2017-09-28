namespace Drapper.Tests
{
    public class ExecuteAsyncFixture
    {
        public ICommander<ExecuteAsync> Commander { get; protected set; }

        protected ExecuteAsyncFixture(ICommander<ExecuteAsync> commander)
        {            
            Commander = commander;
        }
    }
}
