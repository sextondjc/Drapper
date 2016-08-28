using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{

    /// <summary>
    /// Simple representation of a currency.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Gets the ISO 4217 numeric code.
        /// </summary>        
        [Required(AllowEmptyStrings = false, ErrorMessage = Messages.NumericCodeRequired)]
        [StringLength(3, MinimumLength = 3, ErrorMessage = Messages.NumericCodeLengthViolation)]
        public string NumericCode { get; }

        /// <summary>
        /// Gets the ISO 4217 alphabetic code.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = Messages.AlphabeticCodeRequired)]
        [StringLength(3, MinimumLength = 3, ErrorMessage = Messages.AlphabeticCodeLengthViolation)]
        public string AlphabeticCode { get; }

        /// <summary>
        /// Gets or sets the currency name.
        /// </summary>        
        [Required(AllowEmptyStrings = false, ErrorMessage = Messages.NameRequired)]
        [StringLength(255, ErrorMessage = Messages.NameLengthViolation)]
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        /// <param name="numericCode">The numeric code.</param>
        /// <param name="alphabeticCode">The alphabetic code.</param>
        /// <param name="name">The name.</param>
        public Currency(
            string numericCode, 
            string alphabeticCode, 
            string name)
        {
            // the input variables could (in fact, should) be validated on the way in 
            // using the Drapper.Validation.Contract.Require() method. 
            // e.g.
            // Require(!string.IsNullOrWhiteSpace(numericCode), Messages.NumericCodeRequired);
            // Require(numericCode.Length != 3, Messages.NumericCodeLengthViolation);
                        
            this.NumericCode = numericCode;
            this.AlphabeticCode = alphabeticCode;
            this.Name = name;
        }

        private static class Messages
        {
            internal const string NumericCodeRequired = "Numeric code is a required field.";
            internal const string NumericCodeLengthViolation = "Numeric code must be exactly 3 characters long.";
            internal const string AlphabeticCodeRequired = "Alphabetic code is a required field.";
            internal const string AlphabeticCodeLengthViolation = "Alphabetic code must be exactly 3 characters long.";
            internal const string NameRequired = "Name is a required field.";
            internal const string NameLengthViolation = "Name cannot exceed 255 characters.";
        }
    }
}
