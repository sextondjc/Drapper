// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;

namespace Drapper.Validation.Attributes
{
    /// <summary>
    /// Used to specify date options for the <see cref="RequiredDateAttribute"/>
    /// </summary>
    [Flags]
    public enum RequiredDateOptions
    {
        None = 0,
        NotUtc = 1,
        UtcOnly = 2,
        FutureOnly = 4,
        PastOnly = 8
    }
}
