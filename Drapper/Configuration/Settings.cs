// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Collections.Generic;

namespace Drapper.Configuration
{
    /// <summary>
    /// Concrete implementation for the Settings type. 
    /// </summary>
    /// <seealso cref="Drapper.Configuration.ISettings" />
    public class Settings : ISettings
    {
        /// <summary>
        /// Gets or sets the namespace settings.
        /// </summary>
        /// <value>
        /// The namespace settings.
        /// </value>
        public IEnumerable<NamespaceSetting> Namespaces { get; set; }                       
    }    
}
