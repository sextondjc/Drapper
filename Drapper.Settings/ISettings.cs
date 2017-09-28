//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;

namespace Drapper.Settings
{
    public interface ISettings<TCommandSetting> where TCommandSetting : ICommandSetting
    {
        IEnumerable<INamespaceSetting<TCommandSetting>> Namespaces { get; }
        IEnumerable<Type> Types { get; set; }
    }
}