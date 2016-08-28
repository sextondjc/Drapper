using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Models;
using static Sample.Repositories.Tests.CommanderHelper;

namespace Sample.Repositories.Tests.CurrencyRepositoryTests
{
    [TestClass]
    public class Create
    {
        private Currency _test = new Currency("000", "AAA", "Test Currency AAA");

        #region / init & cleanup /

        [TestInitialize]
        public void Initialize()
        {
            Cleanup();
        }

        [TestCleanup]
        public void Cleanup()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var result = repository.Delete(_test);                
            }
        }

        #endregion

        [TestMethod]
        public void Successfully()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var result = repository.Create(_test);
                Assert.IsNotNull(result);
            }
        }
    }
}
