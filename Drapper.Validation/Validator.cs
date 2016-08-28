// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.ComponentModel.DataAnnotations.Validator;

namespace Drapper.Validation
{
    /// <summary>
    /// A lightweight validation helper class which can be used to 
    /// perform model validation in repository classes.
    /// </summary>
    public sealed class Validator
    {
        /// <summary>
        /// Attempts to validate a model based on its property attributes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        public static void Validate<T>(T item)
        {
            // kick out nulls
            Contract.Require(item != null, "The item passed for validation was null.");
            
            var context = new ValidationContext(
                item,
                serviceProvider: null, 
                items: null);

            var results = new List<ValidationResult>();
            var isValid = TryValidateObject(
                item, 
                context, 
                results,
                validateAllProperties: true
            );

            if (!isValid)
            {
                // build up the validation error message. 
                var builder = new StringBuilder();                
                foreach (var result in results)
                {
                    builder.Append($"{result.ErrorMessage}\r\n");
                }

                throw new ValidationException(builder.ToString());
            }
        }

        public static void ValidateCollection<T>(IEnumerable<T> items)
        {
            Contract.Require(items != null, "The collection passed for validation was null.");
            foreach (var item in items)
            {
                Validate(item);
            }
        }
    }
}
