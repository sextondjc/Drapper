// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Validation.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Drapper.Validation.Tests.Attributes.RequiredDateAttributeTests
{
    [TestClass]
    public class IsValid
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullObjectNotSupported()
        {
            var attribute = new RequiredDateAttribute();
            var result = attribute.IsValid(null);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OnlySupportsDateTime()
        {
            var value = "test";
            var attribute = new RequiredDateAttribute();
            var result = attribute.IsValid(value);
        }

        [TestMethod]
        public void DefaultsToUtc()
        {
            var value = DateTime.Now;
            var attribute = new RequiredDateAttribute();
            var result = attribute.IsValid(value);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NoneOptionReturnsTrue()
        {
            var value = DateTime.Now;
            var options = RequiredDateOptions.None;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SupportsNonUtcDates()
        {
            var value = DateTime.Now;
            var options = RequiredDateOptions.NotUtc;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SupportsFutureOnlyDate()
        {
            var value = DateTime.UtcNow.AddDays(1);
            var options = RequiredDateOptions.FutureOnly;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SupportsFutureOnlyUtcDate()
        {
            var value = DateTime.UtcNow.AddDays(1);
            var options = RequiredDateOptions.FutureOnly | RequiredDateOptions.UtcOnly;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SupportsFutureOnlyNotUtcDate()
        {
            var value = DateTime.Now.AddDays(1);
            var options = RequiredDateOptions.FutureOnly | RequiredDateOptions.NotUtc;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SupportsPastOnlyDate()
        {
            var value = DateTime.UtcNow.AddDays(-1);
            var options = RequiredDateOptions.PastOnly;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SupportsPastOnlyUtcDate()
        {
            var value = DateTime.UtcNow.AddDays(-1);
            var options = RequiredDateOptions.PastOnly | RequiredDateOptions.UtcOnly;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SupportsPastOnlyNotUtcDate()
        {
            var value = DateTime.Now.AddDays(-1);
            var options = RequiredDateOptions.PastOnly | RequiredDateOptions.NotUtc;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PastOnlyAndFutureOnlyIsNotSupported()
        {
            var value = DateTime.Now.AddDays(-1);
            var options = RequiredDateOptions.PastOnly | RequiredDateOptions.FutureOnly;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NoneAndFutureOnlyIsSupported()
        {
            var value = DateTime.Now.AddDays(1);
            var options = RequiredDateOptions.None | RequiredDateOptions.FutureOnly;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NoneAndPastOnlyIsSupported()
        {
            var value = DateTime.Now.AddDays(-1);
            var options = RequiredDateOptions.None | RequiredDateOptions.PastOnly;
            var attribute = new RequiredDateAttribute(options);
            var result = attribute.IsValid(value);
            Assert.IsTrue(result);
        }

    }
}
