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
