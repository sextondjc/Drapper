using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Sample.Repositories.Tests.CommanderHelper;

namespace Sample.Repositories.Tests.CurrencyRepositoryTests
{
    [TestClass]
    public class RetrieveAll
    {
        [TestMethod]
        public void ReturnsPaginatedResult()
        {
            var commander = CreateCommander();
            using (var repository = new CurrencyRepository(commander))
            {
                var result = repository.RetrieveAll(2, 5);
                Assert.IsNotNull(result);
                Assert.AreEqual(5, result.Meta.Size);
                Assert.AreEqual(5, result.Values.Count());
            }
        }
    }
}
