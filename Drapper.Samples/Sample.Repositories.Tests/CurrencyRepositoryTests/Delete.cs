using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Models;
using static Sample.Repositories.Tests.CommanderHelper;

namespace Sample.Repositories.Tests.CurrencyRepositoryTests
{
    [TestClass]
    public class Delete
    {
        private Currency _test = new Currency("001", "AAB", "Test Currency AAB");

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
                var result = repository.Create(_test);
                Assert.IsNotNull(result);
            }
        }

        #endregion

        [TestMethod]
        public void Successfully()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var result = repository.Delete(_test);
                Assert.IsNotNull(result);

                // now try to find it
                var record = repository.Retrieve("001");
                Assert.IsNull(record);
            }
        }
    }
}
