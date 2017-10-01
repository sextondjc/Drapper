//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Collections.Generic;

namespace Drapper.Settings
{
    public interface INamespaceSetting<TCommandSetting> where TCommandSetting : ICommandSetting
    {
        string Namespace { get; set; }
        IEnumerable<ITypeSetting<TCommandSetting>> Types { get; set; }
    }
}