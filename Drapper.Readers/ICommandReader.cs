//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Drapper.Settings;

namespace Drapper.Readers
{
    /// <summary>
    /// Returns an <see cref="ICommandSetting"/> from a configuration source.
    /// </summary>
    public interface ICommandReader<out TCommandSetting> where TCommandSetting : ICommandSetting
    {
        /// <summary>
        /// Gets the <see cref="ICommandSetting"/>
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        TCommandSetting GetCommand(Type type, string key);
    }
}