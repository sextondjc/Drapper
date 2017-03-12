// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================

using System;
using System.IO;
using Drapper.Configuration;
using Drapper.Configuration.Json;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceA.With.Many.Different.Parts;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceB.With.Many.Different.Parts;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceC.With.Many.Different.Parts;
using Newtonsoft.Json;
using SingleLevel;
using Drapper.Tests.ConfigurationTests.Fully.Qualified.NamespaceE.With.Many.Different.Parts;
using Drapper.Tests.Relative.Path.Tests;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests.ConfigurationTests.JsonFileCommandReaderTests
{    
    public class GetCommand
    {
        #region / init /
        
        private ISettings GetFromFile() => JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Drapper.Test.Settings.json"));

        #endregion

        [Fact]        
        public void NullSettingsThrowsArgumentNullException()
        {
            var reader = Throws<ArgumentNullException>(() => new JsonFileCommandReader(null));
        }

        [Fact]
        public void FallsBackToNamespaceForTypeSettings()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeA), "FallsBackToNamespace");

            NotNull(result);
            Equal("select 'TypeA';", result.CommandText);
        }

        [Fact]
        public void SupportsSingleLevelNamespace()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeD), "SupportsSingleLevelNamespace");

            NotNull(result);
            Equal("select 'TypeD';", result.CommandText);
        }
                        
        [Fact]
        public void Successfully()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(GetCommand), "ExplicitKey");

            NotNull(result);
        }

        [Fact]        
        public void NullTypeArgumentThrowsArgumentNullException()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(null, "ExplicitKey"));
        }
        
        [Fact]        
        public void UnknownTypeThrowsArgumentNullException()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(typeof(JsonFileCommandReader), "ExplicitKey"));
        }
        
        [Fact]        
        public void NullKeyArgumentThrowsArgumentNullException()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(typeof(GetCommand), null));
        }

        [Fact]        
        public void UnknownKeyThrowsArgumentNullException()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = Throws<ArgumentNullException>(() => reader.GetCommand(typeof(GetCommand), "Unknown"));
        }

        #region / path tests /

        [Fact]
        public void SupportsFileFoundOnNamespacePathSettings()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeB), "SupportsFileFoundOnNamespacePathSettings");

            NotNull(result);
        }

        [Fact]
        public void SupportsFileFoundOnTypePathSetting()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeC), "SupportsFileFoundOnTypePathSettings");

            NotNull(result);
        }

        [Fact]
        public void SupportsFileFoundOnRelativePathWithNamespaceSettingPath()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeE), "SupportsFileFoundOnRelativePath");

            NotNull(result);
        }

        [Fact]
        public void SupportsFileFoundOnRelativeUpPathWithNamespaceSettingPath()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeF), "SupportsFileFoundOnRelativeUpPath");

            NotNull(result);
        }

        [Fact]
        public void SupportsFileFoundOnRelativeDownPathWithNamespaceSettingPath()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeG), "SupportsFileFoundOnRelativeDownPath");

            NotNull(result);
        }

        [Fact]
        public void SupportsFileFoundOnRelativePathWithoutNamespaceSettingPath()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeH), "SupportsFileFoundOnRelativePath");

            NotNull(result);
        }

        [Fact]
        public void SupportsFileFoundOnRelativeDownPathWithoutNamespaceSettingPath()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = reader.GetCommand(typeof(TypeJ), "SupportsFileFoundOnRelativeDownPath");

            NotNull(result);
        }

        [Fact]        
        public void LeadingCharactersThrowsFileNotFoundException()
        {
            var reader = new JsonFileCommandReader(GetFromFile());
            var result = Throws<FileNotFoundException>(() => reader.GetCommand(typeof(TypeK), "LeadingCharactersThrowsException"));
        }

        #endregion
    }
}
