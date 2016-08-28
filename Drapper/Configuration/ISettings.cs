// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Collections.Generic;

namespace Drapper.Configuration
{
    /// <summary>
    /// Provides configuration options for Drapper. 
    /// </summary>
    public interface ISettings
    {
        /// <summary>
        /// Gets or sets the namespace settings.
        /// </summary>        
        IEnumerable<NamespaceSetting> Namespaces { get; set; }
    };
}
