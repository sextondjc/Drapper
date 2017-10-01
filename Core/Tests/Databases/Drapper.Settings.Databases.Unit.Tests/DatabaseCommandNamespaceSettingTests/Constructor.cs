//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Settings.Databases.Unit.Tests.DatabaseCommandNamespaceSettingTests
{
    public class Constructor
    {
        public Constructor()
        {
            _types = new List<DatabaseCommandTypeSetting>
            {
                new DatabaseCommandTypeSetting("test_types", new Dictionary<string, DatabaseCommandSetting>
                {
                    ["test"] = new DatabaseCommandSetting("test", "select 1")
                })
            };
        }

        private readonly IEnumerable<DatabaseCommandTypeSetting> _types;

        [Fact]
        public void EmptyTypesListThrowsArgumentException()
        {
            var result = Throws<ArgumentException>(() =>
                new DatabaseCommandNamespaceSetting("test_namespace", new List<DatabaseCommandTypeSetting>()));
            const string expect =
                "'test_namespace' must have at least 1 Type setting to be valid. Please check settings.";
            Equal(expect, result.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceNameThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() => new DatabaseCommandNamespaceSetting(null, _types));
            var empty = Throws<ArgumentNullException>(() =>
                new DatabaseCommandNamespaceSetting(string.Empty, _types));
            var whitespace =
                Throws<ArgumentNullException>(() => new DatabaseCommandNamespaceSetting("", _types));

            const string expect =
                "Value cannot be null.\r\nParameter name: namespace. All namespace entries must have a name to be valid. Please check settings for an empty namespace namespace.";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullTypesListThrowsArgumentNullException()
        {
            var result =
                Throws<ArgumentNullException>(() => new DatabaseCommandNamespaceSetting("test_namespace", null));
            const string expect =
                "Value cannot be null.\r\nParameter name: types. The types collection for 'test_namespace' is null. Please check settings.";
            Equal(expect, result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new DatabaseCommandNamespaceSetting("test", _types);
            Equal("test", result.Namespace);
            NotNull(result.Types);
            True(result.Types.Any());
        }
    }
}