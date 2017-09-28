//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:52)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

namespace Drapper.Tests
{
    public class ExecuteFixture
    {
        public ICommander<Execute> Commander { get; protected set; }

        protected ExecuteFixture(ICommander<Execute> commander)
        {
            Commander = commander;
        }
    }
}