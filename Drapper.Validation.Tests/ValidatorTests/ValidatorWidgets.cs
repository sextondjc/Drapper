// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.ComponentModel.DataAnnotations;

namespace Drapper.Validation.Tests.ValidatorTests
{
    // simple poco's for testing Validator. 
    // all widgets derive from a common interface
    // so that I stick 'em all in a list for 
    // the Validate<IEnumerable<T>> overload

    public class ValidatorWidget 
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }  
}
