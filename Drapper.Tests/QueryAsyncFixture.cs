namespace Drapper.Tests
{
    public class QueryAsyncFixture
    {
        public ICommander<QueryAsync> Commander { get; protected set; }

        protected QueryAsyncFixture(ICommander<QueryAsync> commander)
        {            
            Commander = commander;
        }
    }
}
