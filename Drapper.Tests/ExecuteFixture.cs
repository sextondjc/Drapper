namespace Drapper.Tests
{
    public class ExecuteFixture
    {
        public ICommander<Execute> Commander { get; protected set; }

        protected ExecuteFixture(ICommander<Execute> commander)
        {            
            Commander = commander;
        }
    }
}
