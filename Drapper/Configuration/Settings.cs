// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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
