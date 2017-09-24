using System;
using System.Collections.Generic;
using Drapper.Settings.Databases;
using Xunit;
using Drapper.Databases.Readers;

namespace Drapper.Readers.Databases.Unit.Tests.DatabaseCommandReaderTests
{
    public class GetCommand
    {
        private readonly IDatabaseCommandReader _reader;

        public GetCommand()
        {     
            var settings = new DatabaseCommanderSettings(
                new List<DatabaseCommandNamespaceSetting> {
                    new DatabaseCommandNamespaceSetting(
                        typeof(GetCommand).Namespace,
                        new List<DatabaseCommandTypeSetting>
                        {
                            new DatabaseCommandTypeSetting(
                                typeof(Constructor).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] = new DatabaseCommandSetting("test.alias", "select 'Readers.Test.Settings'")
                                }),
                            new DatabaseCommandTypeSetting(
                                typeof(GetCommand).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] = new DatabaseCommandSetting("test.alias", "select 'Readers.Test.Settings.GetCommand'[Result];")
                                })
                        })
                }
                , new List<ConnectionStringSetting>
                {
                    new ConnectionStringSetting("test.alias", "providerName", "connectionString")
                });
            
            _reader = new DatabaseCommandReader(settings);
        }

        [Fact]
        public void NullTypePassedThrowsArgumentNullException()
        {
            var result = Assert.Throws<ArgumentNullException>(() => _reader.GetCommand(null, "test"));
            Assert.Equal("Value cannot be null.\r\nParameter name: type", result.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceKeyThrowsArgumentNullException()
        {
            var nulled = Assert.Throws<ArgumentNullException>(() => _reader.GetCommand(typeof(GetCommand), null));
            var empty = Assert.Throws<ArgumentNullException>(() => _reader.GetCommand(typeof(GetCommand), string.Empty));
            var whitespace = Assert.Throws<ArgumentNullException>(() => _reader.GetCommand(typeof(GetCommand), ""));

            const string expect = "Value cannot be null.\r\nParameter name: key";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NoNamespaceSettingThrowsNullReferenceException()
        {
            var result = Assert.Throws<NullReferenceException>(() => _reader.GetCommand(typeof(NoNamespaceType), "NoNamespaceSettingThrowsNullReferenceException"));
            Assert.Equal($"'{typeof(NoNamespaceType).FullName}' does not belong to any NamespaceSetting.\r\nPlease check settings.", result.Message);
        }

        [Fact]
        public void NoTypeSettingThrowsNullReferenceException()
        {
            var result = Assert.Throws<NullReferenceException>(() => _reader.GetCommand(typeof(InternalTest), "NoTypeSettingThrowsNullReferenceException"));
            var expect = $"The type '{typeof(InternalTest).FullName}' has no entry in the type settings of namespace '{typeof(InternalTest).Namespace}'. Please add a type setting entry to the namespace setting.";
            Assert.Equal(expect, result.Message);
        }

        [Fact]
        public void NoCommandSettingThrowsNullReferenceException()
        {
            var result = Assert.Throws<NullReferenceException>(() => _reader.GetCommand(typeof(GetCommand), "DoesNotExist"));
            var expect = $"The command setting 'DoesNotExist' has no entry for the type setting '{typeof(GetCommand).FullName}'. Please add a command setting entry to the type setting.";            
            Assert.Equal(expect, result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = _reader.GetCommand(typeof(GetCommand), "Retrieve");
            Assert.NotNull(result);
            Assert.Equal("test.alias", result.ConnectionAlias);
            Assert.Equal("select 'Readers.Test.Settings.GetCommand'[Result];", result.CommandText);             
        }
        
        private class InternalTest { }
    }    
}

namespace Drapper.Databases.Readers
{
    internal class NoNamespaceType { }
}