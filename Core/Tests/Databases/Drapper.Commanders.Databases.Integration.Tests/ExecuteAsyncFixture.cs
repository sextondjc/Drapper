//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

namespace Drapper.Commanders.Databases.Integration.Tests
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