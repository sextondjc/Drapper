//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using Drapper.Settings.Databases;
using Xunit;
using Drapper.Commanders.Databases.Readers;
using static Xunit.Assert;

namespace Drapper.Readers.Databases.Unit.Tests.DatabaseCommandReaderTests
{
    public class GetCommand
    {
        public GetCommand()
        {
            var settings = new DatabaseCommanderSettings(
                new List<DatabaseCommandNamespaceSetting>
                {
                    new DatabaseCommandNamespaceSetting(
                        typeof(GetCommand).Namespace,
                        new List<DatabaseCommandTypeSetting>
                        {
                            new DatabaseCommandTypeSetting(
                                typeof(Constructor).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] =
                                    new DatabaseCommandSetting("test.alias", "select 'Readers.Test.Settings'")
                                }),
                            new DatabaseCommandTypeSetting(
                                typeof(GetCommand).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] = new DatabaseCommandSetting("test.alias",
                                        "select 'Readers.Test.Settings.GetCommand'[Result];")
                                })
                        })
                }
                , new List<ConnectionStringSetting>
                {
                    new ConnectionStringSetting("test.alias", "providerName", "connectionString")
                });

            _reader = new DatabaseCommandReader(settings);
        }

        private readonly IDatabaseCommandReader _reader;

        private class InternalTest
        {
        }

        [Fact]
        public void NoCommandSettingThrowsNullReferenceException()
        {
            var result =
                Throws<NullReferenceException>(() => _reader.GetCommand(typeof(GetCommand), "DoesNotExist"));
            var expect =
                $"The command setting 'DoesNotExist' has no entry for the type setting '{typeof(GetCommand).FullName}'. Please add a command setting entry to the type setting.";
            Equal(expect, result.Message);
        }

        [Fact]
        public void NoNamespaceSettingThrowsNullReferenceException()
        {
            var result = Throws<NullReferenceException>(() =>
                _reader.GetCommand(typeof(NoNamespaceType), "NoNamespaceSettingThrowsNullReferenceException"));
            Equal(
                $"'{typeof(NoNamespaceType).FullName}' does not belong to any NamespaceSetting.\r\nPlease check settings.",
                result.Message);
        }

        [Fact]
        public void NoTypeSettingThrowsNullReferenceException()
        {
            var result = Throws<NullReferenceException>(() =>
                _reader.GetCommand(typeof(InternalTest), "NoTypeSettingThrowsNullReferenceException"));
            var expect =
                $"The type '{typeof(InternalTest).FullName}' has no entry in the type settings of namespace '{typeof(InternalTest).Namespace}'. Please add a type setting entry to the namespace setting.";
            Equal(expect, result.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceKeyThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() => _reader.GetCommand(typeof(GetCommand), null));
            var empty = Throws<ArgumentNullException>(() =>
                _reader.GetCommand(typeof(GetCommand), string.Empty));
            var whitespace = Throws<ArgumentNullException>(() => _reader.GetCommand(typeof(GetCommand), ""));

            const string expect = "Value cannot be null.\r\nParameter name: key";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullTypePassedThrowsArgumentNullException()
        {
            var result = Throws<ArgumentNullException>(() => _reader.GetCommand(null, "test"));
            Equal("Value cannot be null.\r\nParameter name: type", result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = _reader.GetCommand(typeof(GetCommand), "Retrieve");
            NotNull(result);
            Equal("test.alias", result.ConnectionAlias);
            Equal("select 'Readers.Test.Settings.GetCommand'[Result];", result.CommandText);
        }
    }
}

namespace Drapper.Commanders.Databases.Readers
{
    internal class NoNamespaceType
    {
    }
}