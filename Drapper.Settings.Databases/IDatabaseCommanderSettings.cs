using System.Collections.Generic;

namespace Drapper.Settings.Databases
{
    public interface IDatabaseCommanderSettings : ISettings<DatabaseCommandSetting>
    {        
        IEnumerable<ConnectionStringSetting> Connections { get; }
    }
}