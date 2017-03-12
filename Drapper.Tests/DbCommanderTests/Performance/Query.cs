// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Drapper.Tests.DbCommanderTests.Performance
{
    [TestClass]
    public class Query
    {
        #region QueryWidget

        public sealed class QueryWidget
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Created { get; set; }
        }

        #endregion

        #region / init & teardown

        [TestInitialize]
        public void Initialize()
        {
            var widget = new QueryWidget();
            // create a new widgets table. 
            using(var commander = CommanderHelper.CreateCommander())
            {
                var result = commander.Execute(widget);                
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            var widget = new QueryWidget();
            // drop the widgets table. 
            using (var commander = CommanderHelper.CreateCommander())
            {
                var result = commander.Execute(widget);                
            }
        }

        #endregion

       // [TestMethod]
        public void SynchronousCalls()
        {
            var started = DateTime.UtcNow;            
            using (var commander = CommanderHelper.CreateCommander())
            {
                var result = commander.Query<dynamic>(new { Id = 501 });
            }

            var stopped = DateTime.UtcNow;
            var elapsed = stopped.Subtract(started);
            Console.WriteLine($"Completed in {elapsed.TotalMilliseconds} milliseconds.");
        }
    }
}
