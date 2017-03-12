// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2017.02.09 (22:13)
// modified     : 2017-02-09 (23:04)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using Xunit;

#endregion

namespace Drapper.Tests.Helpers
{
    [CollectionDefinition("Integration")]
    public class DatabaseCollection : ICollectionFixture<DatabaseFixture> { }


}