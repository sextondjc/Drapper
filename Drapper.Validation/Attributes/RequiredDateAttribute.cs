// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.ComponentModel.DataAnnotations;
using static Drapper.Validation.Attributes.RequiredDateOptions;

namespace Drapper.Validation.Attributes
{
    /// <summary>
    /// Specifies that a DateTime property must be populated and,
    /// optionally, must be UTC time and/or in the future. 
    /// The default behaviour is to assume that the value is 
    /// UTC. 
    /// </summary>
    public class RequiredDateAttribute : ValidationAttribute
    {
        public RequiredDateOptions Options { get; }

        public RequiredDateAttribute()
        {
            // default to UTC. 
            this.Options = UtcOnly;
        }

        public RequiredDateAttribute(RequiredDateOptions options)
        {
            this.Options = options;
        }
        
        public override bool IsValid(object value)
        {
            // preconditions. 
            Contract.Require(value != null, "A value must be supplied to the RequiredDateAttribute.");
            Contract.Require(value.GetType() == typeof(DateTime), "The value supplied to the RequiredDateAttribute ({0}) was not a DateTime type.", value);

            var result = false;                        
            var toValidate = Convert.ToDateTime(value);
            
            // switch on our supported options. 
            switch (Options)
            {
                case None:
                    result = true;
                    break;
                case NotUtc:
                    result = (toValidate.Kind != DateTimeKind.Utc);
                    ErrorMessage = "The DateTime supplied should not be in UTC.";
                    break;
                case UtcOnly:
                    result = (toValidate.Kind == DateTimeKind.Utc);
                    ErrorMessage = "The DateTime supplied must be in UTC.";
                    break;
                case FutureOnly:
                case UtcOnly | FutureOnly:
                    result = (toValidate > DateTime.UtcNow);
                    ErrorMessage = "The DateTime supplied must be in UTC and in the future.";
                    break;
                case PastOnly:
                case UtcOnly | PastOnly:
                    result = (toValidate < DateTime.UtcNow);
                    ErrorMessage = "The DateTime supplied must be in UTC and in the past.";
                    break;                
                case NotUtc | FutureOnly:
                    result = ((toValidate.Kind != DateTimeKind.Utc) && (toValidate > DateTime.Now));
                    ErrorMessage = "The DateTime supplied should not be in UTC and must be in the future.";
                    break;
                case NotUtc | PastOnly:
                    result = ((toValidate.Kind != DateTimeKind.Utc) && (toValidate < DateTime.Now));
                    ErrorMessage = "The DateTime supplied should not be in UTC and must be in the past.";
                    break;
                default:
                    // some crazy case which isn't supported.
                    ErrorMessage = "The DateTime supplied did not pass validation. Please check that it meets supported validation rules.";
                    result = false;
                    break;
                
            }

            return result;
        }
    }
}
