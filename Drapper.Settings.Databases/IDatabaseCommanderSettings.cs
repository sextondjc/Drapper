//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Collections.Generic;

namespace Drapper.Settings.Databases
{
    public interface IDatabaseCommanderSettings : ISettings<DatabaseCommandSetting>
    {
        IEnumerable<ConnectionStringSetting> Connections { get; }
    }
}