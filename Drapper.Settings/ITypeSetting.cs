using System.Collections.Generic;

namespace Drapper.Settings
{
    public interface ITypeSetting<TCommandSetting> where TCommandSetting : ICommandSetting
    {
        string Name { get; }                
        IDictionary<string, TCommandSetting> Commands { get; }
    }
}