//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Readers.Databases.Unit.Tests.DatabaseCommandReaderTests
{
    public class Constructor
    {
        [Fact]
        public void NullSettingsThrowsArgumentNullException()
        {
            var result = Throws<ArgumentNullException>(() => new DatabaseCommandReader(null));
            const string expect =
                "Value cannot be null.\r\nParameter name: settings. No settings were passed to DatabaseCommandReader.";
            Equal(expect, result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new DatabaseCommandReader(SettingsDouble.GetSettings());
            NotNull(result);
        }
    }
}