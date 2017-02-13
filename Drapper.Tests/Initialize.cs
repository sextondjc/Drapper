
using Drapper.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;

namespace Drapper.Tests
{
    [TestClass]
    public class Initialize
    {
        [AssemblyInitialize]
        public static void InitializeAssembly(TestContext context)
        {
            WriteLine($"Initializing assembly.");
            EnvironmentHelper.Setup();
        }        
    }
}
