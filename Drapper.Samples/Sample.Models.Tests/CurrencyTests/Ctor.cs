using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using static Drapper.Validation.Validator;

namespace Sample.Models.Tests.CurrencyTests
{
    [TestClass]
    public class Ctor
    {
        [TestMethod]
        public void Successful()
        {
            var currency = new Currency("710", "ZAR", "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NumericCodeNullThrowsValidationException()
        {
            var currency = new Currency(null, "ZAR", "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NumericCodeEmptyThrowsValidationException()
        {
            var currency = new Currency(string.Empty, "ZAR", "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NumericCodeWhitespaceThrowsValidationException()
        {
            var currency = new Currency("   ", "ZAR", "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NumericCodeTooLongThrowsValidationException()
        {
            var currency = new Currency("0710", "ZAR", "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NumericCodeTooShortThrowsValidationException()
        {
            var currency = new Currency("71", "ZAR", "South African Rand");
            Validate(currency);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void AlphabeticCodeNullThrowsValidationException()
        {
            var currency = new Currency("710", null, "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void AlphabeticCodeEmptyThrowsValidationException()
        {
            var currency = new Currency("710", string.Empty, "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void AlphabeticCodeWhitespaceThrowsValidationException()
        {
            var currency = new Currency("710", "   ", "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void AlphabeticCodeTooLongThrowsValidationException()
        {
            var currency = new Currency("710", "ZARR", "South African Rand");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void AlphabeticCodeTooShortThrowsValidationException()
        {
            var currency = new Currency("710", "ZA", "South African Rand");
            Validate(currency);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NameNullThrowsValidationException()
        {
            var currency = new Currency("710", "ZAR", null);
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NameEmptyThrowsValidationException()
        {
            var currency = new Currency("710", "ZAR", string.Empty);
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NameWhitespaceThrowsValidationException()
        {
            var currency = new Currency("710", "ZAR", "   ");
            Validate(currency);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void NameTooLongThrowsValidationException()
        {
            var name = new string('A', 256);
            var currency = new Currency("710", "ZAR", name);
            Validate(currency);
        }
    }
}
