// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;

namespace Drapper.Validation
{
    /// <summary>
    /// A simple precondition checker. Useful for validating method arguments. 
    /// </summary>
    public static class Contract
    {
        public static void Require(bool condition, string message, params object[] args)
        {
            if (!condition)
            {
                throw new ArgumentException(string.Format(message, args));
            }
        }
    }
}
