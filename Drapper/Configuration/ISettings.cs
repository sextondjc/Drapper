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
