// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

using System;
using System.Runtime.CompilerServices;

namespace Drapper.Configuration
{
    /// <summary>
    /// Returns a <see cref="CommandSetting"/> from a configuration source.
    /// </summary>
    public interface ICommandReader
    {        
        /// <summary>
        /// Gets the <see cref="CommandSetting"/>
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        CommandSetting GetCommand(Type type, [CallerMemberName] string key = null);        
    }
}
