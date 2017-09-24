using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Drapper.Settings.Databases.Unit.Tests.DatabaseCommandNamespaceSettingTests
{
    public class Constructor
    {
        private readonly IEnumerable<DatabaseCommandTypeSetting> _types;

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

        [Fact]
        public void NullEmptyWhitespaceNameThrowsArgumentNullException()
        {
            var nulled = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandNamespaceSetting(null, _types));
            var empty = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandNamespaceSetting(string.Empty, _types));
            var whitespace = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandNamespaceSetting("", _types));

            const string expect = "Value cannot be null.\r\nParameter name: namespace. All namespace entries must have a name to be valid. Please check settings for an empty namespace namespace.";
            Assert.Equal(expect, nulled.Message);
            Assert.Equal(expect, empty.Message);
            Assert.Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullTypesListThrowsArgumentNullException()
        {
            var result = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandNamespaceSetting("test_namespace", null));
            const string expect = "Value cannot be null.\r\nParameter name: types. The types collection for 'test_namespace' is null. Please check settings.";
            Assert.Equal(expect, result.Message);
        }

        [Fact]
        public void EmptyTypesListThrowsArgumentException()
        {
            var result = Assert.Throws<ArgumentException>(() => new DatabaseCommandNamespaceSetting("test_namespace", new List<DatabaseCommandTypeSetting>()));
            const string expect = "'test_namespace' must have at least 1 Type setting to be valid. Please check settings.";
            Assert.Equal(expect, result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new DatabaseCommandNamespaceSetting("test", _types);
            Assert.Equal("test", result.Namespace);
            Assert.NotNull(result.Types);
            Assert.True(result.Types.Any());
        }
    }
}
