using System;
using Xunit;

namespace Drapper.Readers.Databases.Unit.Tests.DatabaseCommandReaderTests
{
    public class Constructor
    {       
        [Fact]
        public void NullSettingsThrowsArgumentNullException()
        {
            var result = Assert.Throws<ArgumentNullException>(() => new DatabaseCommandReader(null));
            const string expect = "Value cannot be null.\r\nParameter name: settings. No settings were passed to DatabaseCommandReader.";
            Assert.Equal(expect, result.Message);
        }

        [Fact]
        public void Successfully()
        {            
            var result = new DatabaseCommandReader(SettingsDouble.GetSettings());
            Assert.NotNull(result);
        }
    }
}
