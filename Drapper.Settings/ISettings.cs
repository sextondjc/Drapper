using System.Collections.Generic;

namespace Drapper.Settings
{
    public interface ISettings<TCommandSetting> where TCommandSetting : ICommandSetting
    {        
        IEnumerable<INamespaceSetting<TCommandSetting>> Namespaces { get; }        
    }
}