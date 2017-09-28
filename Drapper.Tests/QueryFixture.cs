//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (22:07)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

namespace Drapper.Tests
{
    public class QueryFixture
    {
        public ICommander<Query> Commander { get; protected set; }

        protected QueryFixture(ICommander<Query> commander)
        {
            Commander = commander;
        }
    }
}