// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
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
