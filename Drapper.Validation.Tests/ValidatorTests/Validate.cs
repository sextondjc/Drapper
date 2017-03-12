// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// not to be confused with System.ComponentModel.DataAnnotations Validator. 
using static Drapper.Validation.Validator;

namespace Drapper.Validation.Tests.ValidatorTests
{
    [TestClass]
    public class Validate
    {
        [TestMethod]
        public void ValidatesObject()
        {
            var widget = new ValidatorWidget
            {
                Name = "Pass"
            };

            Validate(widget);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void InvalidObjectThrowsValidationException()
        {
            var widget = new ValidatorWidget();
            Validate(widget);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullObjectThrowsArgumentException()
        {
            Validate<object>(null);
        }

        [TestMethod]
        public void ValidatesCollection()
        {
            var collection = new List<ValidatorWidget>
            {
                new ValidatorWidget { Name = "Test 1" },
                new ValidatorWidget { Name = "Test 2" }
            };

            ValidateCollection(collection);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void InvalidItemInCollectionThrowsValidationException()
        {
            var collection = new List<ValidatorWidget>
            {
                new ValidatorWidget { Name = "Test 1" },
                new ValidatorWidget { Name = "" }
            };

            ValidateCollection(collection);
        }
       
    }
}
