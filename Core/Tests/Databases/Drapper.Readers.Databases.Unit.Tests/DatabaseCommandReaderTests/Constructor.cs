//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

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
            const string expect =
                "Value cannot be null.\r\nParameter name: settings. No settings were passed to DatabaseCommandReader.";
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