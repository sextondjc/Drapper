namespace Drapper.Tests
{
    public class QueryFixture
    {
        public ICommander<Query> Commander { get; protected set; }

        protected QueryFixture(ICommander<Query> commander)
        {            
            Commander = commander;
        }
    }
}
