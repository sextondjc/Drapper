// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration;
using Drapper.Configuration.Json;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceA.With.Many.Different.Parts;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceB.With.Many.Different.Parts;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceC.With.Many.Different.Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Drapper.Tests.ConfigurationTests.JsonFileDefinitionParserTests
{
    [TestClass]
    public class GetCommand
    {
        #region / init /
        
        private Settings GetFromFile() => JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Drapper.Test.Settings.json"));

        #endregion

        [TestMethod]
        public void FallsBackToNamespaceForTypeSettings()
        {
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(typeof(TypeA), "FallsBackToNamespace");

            Assert.IsNotNull(result);
            Assert.AreEqual("select 'TypeA';", result.CommandText);
        }

        [TestMethod]
        public void SupportsFileFoundOnNamespacePathSettings()
        {            
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(typeof(TypeB), "SupportsFileFoundOnNamespacePathSettings");
            
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SupportsFileFoundOnTypePathSetting()
        {
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(typeof(TypeC), "SupportsFileFoundOnTypePathSettings");

            Assert.IsNotNull(result);
        }
                
        [TestMethod]
        public void Successfully()
        {
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(typeof(GetCommand), "ExplicitKey");

            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullTypeArgumentThrowsArgumentException()
        {
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(null, "ExplicitKey");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnknownTypeThrowsArgumentException()
        {
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(typeof(JsonFileCommandReader), "ExplicitKey");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullKeyArgumentThrowsArgumentException()
        {
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(typeof(GetCommand), null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnknownKeyThrowsArgumentException()
        {
            var settings = GetFromFile();
            var parser = new JsonFileCommandReader(settings);
            var result = parser.GetCommand(typeof(GetCommand), "Unknown");            
        }
    }
}
