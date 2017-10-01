//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

namespace Drapper.Commanders.Databases.Integration.Tests
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