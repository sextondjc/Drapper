using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Models;
using static Sample.Repositories.Tests.CommanderHelper;

namespace Sample.Repositories.Tests.CurrencyRepositoryTests
{
    [TestClass]
    public class Update
    {
        private Currency _test = new Currency("002", "AAC", "Test Currency AAB");

        #region / init & cleanup /

        [TestInitialize]
        public void Initialize()
        {
            Cleanup();
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var result = repository.Create(_test);
                Assert.IsNotNull(result);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var record = repository.Retrieve("002");

                if (record != null)
                {
                    var result = repository.Delete(_test);
                    Assert.IsNotNull(result);
                }
            }
        }

        #endregion

        [TestMethod]
        public void Successfully()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var newName = Guid.NewGuid().ToString();
                _test.Name = newName;
                var result = repository.Update(_test);
                Assert.IsNotNull(result);

                // retrieve and assert
                var record = repository.Retrieve("002");
                Assert.IsNotNull(record);
                Assert.AreEqual(newName, _test.Name);                
            }
        }
    }
}
