using System.Collections.Generic;

namespace Drapper.Settings
{    
    public interface INamespaceSetting<TCommandSetting> where TCommandSetting : ICommandSetting
    {
        string Namespace { get; set; }
        IEnumerable<ITypeSetting<TCommandSetting>> Types { get; set; }
    }
}
