// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Validation.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Drapper.Validation.Tests.Attributes.RequiredCollectionAttributeTests
{
    [TestClass]
    public class IsValid
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullObjectThrowsArgumentException()
        {
            var attribute = new RequiredCollectionAttribute(0, 0);
            attribute.IsValid(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void WrongTypeThrowsArgumentException()
        {
            var attribute = new RequiredCollectionAttribute(0, 0);
            attribute.IsValid(attribute);
        }

        [TestMethod]
        public void LengthBelowMinimumReturnsFalse()
        {
            var collection = new List<object>();            
            var attribute = new RequiredCollectionAttribute(1);
            var result = attribute.IsValid(collection);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthAboveMaximumReturnsFalse()
        {
            var collection = new List<int> { 1, 2, 3 };
            var attribute = new RequiredCollectionAttribute(0, 2);
            var result = attribute.IsValid(collection);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthMatchesMinimumReturnsTrue()
        {
            var collection = new List<int> { 1 };
            var attribute = new RequiredCollectionAttribute(1);
            var result = attribute.IsValid(collection);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthAboveMinimumReturnsTrue()
        {
            var collection = new List<int> { 1, 2, 3 };
            var attribute = new RequiredCollectionAttribute(2);
            var result = attribute.IsValid(collection);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthBelowMaximumReturnsTrue()
        {
            var collection = new List<int> { 1, 2, 3 };
            var attribute = new RequiredCollectionAttribute(0,5);
            var result = attribute.IsValid(collection);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthBetweenMinimumAndMaximumReturnsTrue()
        {
            var collection = new List<int> { 1, 2, 3 };
            var attribute = new RequiredCollectionAttribute(1, 5);
            var result = attribute.IsValid(collection);
            Assert.IsTrue(result);
        }        
    }
}
