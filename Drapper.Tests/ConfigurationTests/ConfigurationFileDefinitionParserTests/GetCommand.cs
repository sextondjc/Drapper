// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration.Xml;
using System;
using System.Data;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceA.With.Many.Different.Parts;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests.ConfigurationTests.ConfigurationFileDefinitionParserTests
{    
    public class GetCommand
    {
        [Fact]
        public void FallsBackToNamespaceForTypeSettings()
        {            
            var reader = new ConfigurationFileCommandReader();
            var result = reader.GetCommand(typeof(TypeA), "FallsBackToNamespace");
            
            NotNull(result);
            Equal("select 'TypeA';", result.CommandText);
        }
        
        [Fact]
        public void Successfully()
        {
            var reader = new ConfigurationFileCommandReader();
            var result = reader.GetCommand(typeof(GetCommand), "ExplicitKey");

            // assert values 
            Equal("select @Id [Result]", result.CommandText);
            Equal("TestId", result.Split);
            Equal(IsolationLevel.ReadCommitted, result.IsolationLevel);
             
            NotNull(result);
        }

        [Fact]        
        public void NullTypeArgumentThrowsArgumentNullException()
        {
            var reader = new ConfigurationFileCommandReader();
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(null, "ExplicitKey"));
        }

        [Fact]        
        public void UnknownTypeThrowsArgumentNullException()
        {
            var reader = new ConfigurationFileCommandReader();
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(typeof(ConfigurationFileCommandReader), "ExplicitKey"));
        }

        [Fact]        
        public void NullKeyArgumentThrowsArgumentNullException()
        {
            var reader = new ConfigurationFileCommandReader();
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(typeof(GetCommand), null));
        }

        [Fact]        
        public void UnknownKeyThrowsArgumentNullException()
        {
            var reader = new ConfigurationFileCommandReader();
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(typeof(GetCommand), "Unknown"));
        }
    }
}
