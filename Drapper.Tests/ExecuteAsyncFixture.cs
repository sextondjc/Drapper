//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (21:36)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

namespace Drapper.Tests
{
    public class ExecuteAsyncFixture
    {
        public ICommander<ExecuteAsync> Commander { get; protected set; }

        protected ExecuteAsyncFixture(ICommander<ExecuteAsync> commander)
        {
            Commander = commander;
        }
    }
}