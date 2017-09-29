//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:44)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Drapper.Tests.Models;
using Xunit;

namespace Drapper.Databases.Integration.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract partial class QueryAsync
    {
        [Fact]
        public async Task MultimapFiveTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithFiveParameters);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoD>>(result);
            Assert.True(result.Any());
            Assert.Equal(3, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(21, first.Id);
            Assert.Equal("Multimap: 21", first.Name);
            Assert.Equal(35, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(1, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 1", pocoA.Name);
            Assert.Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(6, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 6", pocoB.Name);
            Assert.Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(11, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 11", pocoC.Name);
            Assert.Equal(25, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Assert.Equal(16, pocoD.PocoD_Id);
            Assert.Equal("POCO D: 16", pocoD.Name);
            Assert.Equal(30, pocoD.Value);
        }

        [Fact]
        public async Task MultimapFiveTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithFiveParameters, new {Id = 8});

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoD>>(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(28, first.Id);
            Assert.Equal("Multimap: 28", first.Name);
            Assert.Equal(42, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(8, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 8", pocoA.Name);
            Assert.Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(13, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 13", pocoB.Name);
            Assert.Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(18, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 18", pocoC.Name);
            Assert.Equal(32, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Assert.Equal(23, pocoD.PocoD_Id);
            Assert.Equal("POCO D: 23", pocoD.Name);
            Assert.Equal(37, pocoD.Value);
        }

        [Fact]
        public async Task MultimapFourTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithFourParameters);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoC>>(result);
            Assert.True(result.Any());
            Assert.Equal(3, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(16, first.Id);
            Assert.Equal("Multimap: 16", first.Name);
            Assert.Equal(30, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(1, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 1", pocoA.Name);
            Assert.Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(6, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 6", pocoB.Name);
            Assert.Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(11, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 11", pocoC.Name);
            Assert.Equal(25, pocoC.Value);
        }

        [Fact]
        public async Task MultimapFourTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithFourParameters, new {Id = 8});

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoC>>(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(23, first.Id);
            Assert.Equal("Multimap: 23", first.Name);
            Assert.Equal(37, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(8, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 8", pocoA.Name);
            Assert.Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(13, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 13", pocoB.Name);
            Assert.Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(18, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 18", pocoC.Name);
            Assert.Equal(32, pocoC.Value);
        }

        [Fact]
        public async Task MultimapSevenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithSevenParameters);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoF>>(result);
            Assert.True(result.Any());
            Assert.Equal(3, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(31, first.Id);
            Assert.Equal("Multimap: 31", first.Name);
            Assert.Equal(45, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(1, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 1", pocoA.Name);
            Assert.Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(6, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 6", pocoB.Name);
            Assert.Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(11, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 11", pocoC.Name);
            Assert.Equal(25, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Assert.Equal(16, pocoD.PocoD_Id);
            Assert.Equal("POCO D: 16", pocoD.Name);
            Assert.Equal(30, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Assert.Equal(21, pocoE.PocoE_Id);
            Assert.Equal("POCO E: 21", pocoE.Name);
            Assert.Equal(35, pocoE.Value);

            // poco F:
            var pocoF = first.PocoF;
            Assert.Equal(26, pocoF.PocoF_Id);
            Assert.Equal("POCO F: 26", pocoF.Name);
            Assert.Equal(40, pocoF.Value);
        }

        [Fact]
        public async Task MultimapSevenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithSevenParameters, new {Id = 8});

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoF>>(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(38, first.Id);
            Assert.Equal("Multimap: 38", first.Name);
            Assert.Equal(52, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(8, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 8", pocoA.Name);
            Assert.Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(13, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 13", pocoB.Name);
            Assert.Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(18, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 18", pocoC.Name);
            Assert.Equal(32, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Assert.Equal(23, pocoD.PocoD_Id);
            Assert.Equal("POCO D: 23", pocoD.Name);
            Assert.Equal(37, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Assert.Equal(28, pocoE.PocoE_Id);
            Assert.Equal("POCO E: 28", pocoE.Name);
            Assert.Equal(42, pocoE.Value);

            // poco F:
            var pocoF = first.PocoF;
            Assert.Equal(33, pocoF.PocoF_Id);
            Assert.Equal("POCO F: 33", pocoF.Name);
            Assert.Equal(47, pocoF.Value);
        }

        [Fact]
        public async Task MultimapSixTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithSixParameters);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoE>>(result);
            Assert.True(result.Any());
            Assert.Equal(3, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(26, first.Id);
            Assert.Equal("Multimap: 26", first.Name);
            Assert.Equal(40, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(1, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 1", pocoA.Name);
            Assert.Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(6, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 6", pocoB.Name);
            Assert.Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(11, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 11", pocoC.Name);
            Assert.Equal(25, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Assert.Equal(16, pocoD.PocoD_Id);
            Assert.Equal("POCO D: 16", pocoD.Name);
            Assert.Equal(30, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Assert.Equal(21, pocoE.PocoE_Id);
            Assert.Equal("POCO E: 21", pocoE.Name);
            Assert.Equal(35, pocoE.Value);
        }

        [Fact]
        public async Task MultimapSixTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithSixParameters, new {Id = 8});

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoE>>(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(33, first.Id);
            Assert.Equal("Multimap: 33", first.Name);
            Assert.Equal(47, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(8, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 8", pocoA.Name);
            Assert.Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(13, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 13", pocoB.Name);
            Assert.Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Assert.Equal(18, pocoC.PocoC_Id);
            Assert.Equal("POCO C: 18", pocoC.Name);
            Assert.Equal(32, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Assert.Equal(23, pocoD.PocoD_Id);
            Assert.Equal("POCO D: 23", pocoD.Name);
            Assert.Equal(37, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Assert.Equal(28, pocoE.PocoE_Id);
            Assert.Equal("POCO E: 28", pocoE.Name);
            Assert.Equal(42, pocoE.Value);
        }

        [Fact]
        public async Task MultimapThreeTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithThreeParameters);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoB>>(result);
            Assert.True(result.Any());
            Assert.Equal(3, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(11, first.Id);
            Assert.Equal("Multimap: 11", first.Name);
            Assert.Equal(25, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(1, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 1", pocoA.Name);
            Assert.Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(6, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 6", pocoB.Name);
            Assert.Equal(20, pocoB.Value);
        }

        [Fact]
        public async Task MultimapThreeTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithThreeParameters, new {Id = 8});

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoB>>(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(18, first.Id);
            Assert.Equal("Multimap: 18", first.Name);
            Assert.Equal(32, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(8, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 8", pocoA.Name);
            Assert.Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Assert.Equal(13, pocoB.PocoB_Id);
            Assert.Equal("POCO B: 13", pocoB.Name);
            Assert.Equal(27, pocoB.Value);
        }

        [Fact]
        public async Task MultimapTwoTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithTwoParameters);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoA>>(result);
            Assert.True(result.Any());
            Assert.Equal(3, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(6, first.Id);
            Assert.Equal("Multimap: 6", first.Name);
            Assert.Equal(20, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(1, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 1", pocoA.Name);
            Assert.Equal(15, pocoA.Value);
        }

        [Fact]
        public async Task MultimapTwoTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multimap.WithTwoParameters, new {Id = 8});

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<MultiMapPocoA>>(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count());

            // first record
            var first = result.First();
            Assert.Equal(13, first.Id);
            Assert.Equal("Multimap: 13", first.Name);
            Assert.Equal(27, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Assert.Equal(8, pocoA.PocoA_Id);
            Assert.Equal("POCO A: 8", pocoA.Name);
            Assert.Equal(22, pocoA.Value);
        }
    }
}