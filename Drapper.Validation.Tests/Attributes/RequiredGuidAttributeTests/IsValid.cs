// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Validation.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Drapper.Validation.Tests.Attributes.RequiredGuidAttributeTests
{
    [TestClass]
    public class IsValid
    {
        [TestMethod]
        public void ValidGuidReturnsTrue()
        {
            var value = Guid.NewGuid();

            var attribute = new RequiredGuidAttribute();
            var result = attribute.IsValid(value);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NullValueReturnsFalse()
        {
            var attribute = new RequiredGuidAttribute();
            var result = attribute.IsValid(null);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NonGuidReturnsFalse()
        {
            var attribute = new RequiredGuidAttribute();
            var result = attribute.IsValid("Test");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmptyGuidReturnsFalse()
        {
            var attribute = new RequiredGuidAttribute();
            var result = attribute.IsValid(Guid.Empty);

            Assert.IsFalse(result);
        }

        
    }
}
