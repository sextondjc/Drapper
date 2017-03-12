// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Drapper.Validation.Tests.ContractTests
{
    [TestClass]
    public class Require
    {
        [TestMethod]
        public void ValidConditionWillNotThrowAnException()
        {
            var condition = true;
            Contract.Require(condition, "Validation test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidConditionThrowsArgumentException()
        {
            var condition = false;
            Contract.Require(condition, "Validation test");
        }
    }
}