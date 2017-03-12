// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.ComponentModel.DataAnnotations;

namespace Drapper.Validation.Attributes
{
    /// <summary>
    /// Specifies that a required GUID property must be 
    /// populated with a non-empty GUID.
    /// </summary>
    public class RequiredGuidAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            // checks:
            // 1. not null
            // 2. is typeof(Guid)
            // 3. !Guid.Empty

            var result = false;

            if(value != null)
            {
                if(value.GetType() == typeof(Guid))
                {
                    if(((Guid)value) != Guid.Empty)
                    {
                        result = true;
                    }
                    else
                    {
                        ErrorMessage = "The property may not be an empty GUID";
                    }
                }
                else
                {
                    ErrorMessage = "The property must be of type GUID";
                }
            }
            else
            {
                ErrorMessage = "The GUID property may not be null";
            }
            
            return result;
        }
    }
}
