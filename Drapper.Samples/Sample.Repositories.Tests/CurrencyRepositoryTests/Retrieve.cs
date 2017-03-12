using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Sample.Repositories.Tests.CommanderHelper;

namespace Sample.Repositories.Tests.CurrencyRepositoryTests
{
    [TestClass]
    public class Retrieve
    {
        [TestMethod]
        public void ReturnsExistingRecord()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var result = repository.Retrieve("710");
                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public void ReturnsNullForNoRecord()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var result = repository.Retrieve("123");
                Assert.IsNull(result);
            }
        }
    }
}
