//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (15:51)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

namespace Drapper.Databases.Integration.Tests
{
    public class QueryAsyncFixture
    {
        public ICommander<QueryAsync> Commander { get; protected set; }

        protected QueryAsyncFixture(ICommander<QueryAsync> commander)
        {
            Commander = commander;
        }
    }
}