using Drapper.Tests.Models;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract partial class Query
    {       
        [Fact]
        public void MultimapTwoTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithTwoParameters);

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoA>>(result);
            True(result.Any());
            Equal(3, result.Count());

            // first record
            var first = result.First();
            Equal(6, first.Id);
            Equal("Multimap: 6", first.Name);
            Equal(20, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(1, pocoA.PocoA_Id);
            Equal("POCO A: 1", pocoA.Name);
            Equal(15, pocoA.Value);
        }

        [Fact]
        public void MultimapTwoTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithTwoParameters, new { Id = 8 });

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoA>>(result);
            True(result.Any());
            Equal(1, result.Count());

            // first record
            var first = result.First();
            Equal(13, first.Id);
            Equal("Multimap: 13", first.Name);
            Equal(27, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(8, pocoA.PocoA_Id);
            Equal("POCO A: 8", pocoA.Name);
            Equal(22, pocoA.Value);
        }

        [Fact]
        public void MultimapThreeTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithThreeParameters);

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoB>>(result);
            True(result.Any());
            Equal(3, result.Count());

            // first record
            var first = result.First();
            Equal(11, first.Id);
            Equal("Multimap: 11", first.Name);
            Equal(25, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(1, pocoA.PocoA_Id);
            Equal("POCO A: 1", pocoA.Name);
            Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(6, pocoB.PocoB_Id);
            Equal("POCO B: 6", pocoB.Name);
            Equal(20, pocoB.Value);
        }

        [Fact]
        public void MultimapThreeTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithThreeParameters, new { Id = 8 });

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoB>>(result);
            True(result.Any());
            Equal(1, result.Count());

            // first record
            var first = result.First();
            Equal(18, first.Id);
            Equal("Multimap: 18", first.Name);
            Equal(32, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(8, pocoA.PocoA_Id);
            Equal("POCO A: 8", pocoA.Name);
            Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(13, pocoB.PocoB_Id);
            Equal("POCO B: 13", pocoB.Name);
            Equal(27, pocoB.Value);
        }

        [Fact]
        public void MultimapFourTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithFourParameters);

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoC>>(result);
            True(result.Any());
            Equal(3, result.Count());

            // first record
            var first = result.First();
            Equal(16, first.Id);
            Equal("Multimap: 16", first.Name);
            Equal(30, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(1, pocoA.PocoA_Id);
            Equal("POCO A: 1", pocoA.Name);
            Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(6, pocoB.PocoB_Id);
            Equal("POCO B: 6", pocoB.Name);
            Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(11, pocoC.PocoC_Id);
            Equal("POCO C: 11", pocoC.Name);
            Equal(25, pocoC.Value);
        }

        [Fact]
        public void MultimapFourTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithFourParameters, new { Id = 8 });

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoC>>(result);
            True(result.Any());
            Equal(1, result.Count());

            // first record
            var first = result.First();
            Equal(23, first.Id);
            Equal("Multimap: 23", first.Name);
            Equal(37, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(8, pocoA.PocoA_Id);
            Equal("POCO A: 8", pocoA.Name);
            Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(13, pocoB.PocoB_Id);
            Equal("POCO B: 13", pocoB.Name);
            Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(18, pocoC.PocoC_Id);
            Equal("POCO C: 18", pocoC.Name);
            Equal(32, pocoC.Value);
        }

        [Fact]
        public void MultimapFiveTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithFiveParameters);

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoD>>(result);
            True(result.Any());
            Equal(3, result.Count());

            // first record
            var first = result.First();
            Equal(21, first.Id);
            Equal("Multimap: 21", first.Name);
            Equal(35, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(1, pocoA.PocoA_Id);
            Equal("POCO A: 1", pocoA.Name);
            Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(6, pocoB.PocoB_Id);
            Equal("POCO B: 6", pocoB.Name);
            Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(11, pocoC.PocoC_Id);
            Equal("POCO C: 11", pocoC.Name);
            Equal(25, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Equal(16, pocoD.PocoD_Id);
            Equal("POCO D: 16", pocoD.Name);
            Equal(30, pocoD.Value);
        }

        [Fact]
        public void MultimapFiveTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithFiveParameters, new { Id = 8 });

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoD>>(result);
            True(result.Any());
            Equal(1, result.Count());

            // first record
            var first = result.First();
            Equal(28, first.Id);
            Equal("Multimap: 28", first.Name);
            Equal(42, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(8, pocoA.PocoA_Id);
            Equal("POCO A: 8", pocoA.Name);
            Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(13, pocoB.PocoB_Id);
            Equal("POCO B: 13", pocoB.Name);
            Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(18, pocoC.PocoC_Id);
            Equal("POCO C: 18", pocoC.Name);
            Equal(32, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Equal(23, pocoD.PocoD_Id);
            Equal("POCO D: 23", pocoD.Name);
            Equal(37, pocoD.Value);
        }

        [Fact]
        public void MultimapSixTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithSixParameters);

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoE>>(result);
            True(result.Any());
            Equal(3, result.Count());

            // first record
            var first = result.First();
            Equal(26, first.Id);
            Equal("Multimap: 26", first.Name);
            Equal(40, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(1, pocoA.PocoA_Id);
            Equal("POCO A: 1", pocoA.Name);
            Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(6, pocoB.PocoB_Id);
            Equal("POCO B: 6", pocoB.Name);
            Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(11, pocoC.PocoC_Id);
            Equal("POCO C: 11", pocoC.Name);
            Equal(25, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Equal(16, pocoD.PocoD_Id);
            Equal("POCO D: 16", pocoD.Name);
            Equal(30, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Equal(21, pocoE.PocoE_Id);
            Equal("POCO E: 21", pocoE.Name);
            Equal(35, pocoE.Value);
        }

        [Fact]
        public void MultimapSixTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithSixParameters, new { Id = 8 });

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoE>>(result);
            True(result.Any());
            Equal(1, result.Count());

            // first record
            var first = result.First();
            Equal(33, first.Id);
            Equal("Multimap: 33", first.Name);
            Equal(47, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(8, pocoA.PocoA_Id);
            Equal("POCO A: 8", pocoA.Name);
            Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(13, pocoB.PocoB_Id);
            Equal("POCO B: 13", pocoB.Name);
            Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(18, pocoC.PocoC_Id);
            Equal("POCO C: 18", pocoC.Name);
            Equal(32, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Equal(23, pocoD.PocoD_Id);
            Equal("POCO D: 23", pocoD.Name);
            Equal(37, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Equal(28, pocoE.PocoE_Id);
            Equal("POCO E: 28", pocoE.Name);
            Equal(42, pocoE.Value);
        }

        [Fact]
        public void MultimapSevenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithSevenParameters);

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoF>>(result);
            True(result.Any());
            Equal(3, result.Count());

            // first record
            var first = result.First();
            Equal(31, first.Id);
            Equal("Multimap: 31", first.Name);
            Equal(45, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(1, pocoA.PocoA_Id);
            Equal("POCO A: 1", pocoA.Name);
            Equal(15, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(6, pocoB.PocoB_Id);
            Equal("POCO B: 6", pocoB.Name);
            Equal(20, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(11, pocoC.PocoC_Id);
            Equal("POCO C: 11", pocoC.Name);
            Equal(25, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Equal(16, pocoD.PocoD_Id);
            Equal("POCO D: 16", pocoD.Name);
            Equal(30, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Equal(21, pocoE.PocoE_Id);
            Equal("POCO E: 21", pocoE.Name);
            Equal(35, pocoE.Value);

            // poco F:
            var pocoF = first.PocoF;
            Equal(26, pocoF.PocoF_Id);
            Equal("POCO F: 26", pocoF.Name);
            Equal(40, pocoF.Value);
        }

        [Fact]
        public void MultimapSevenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multimap.WithSevenParameters, new { Id = 8 });

            NotNull(result);
            IsAssignableFrom<IEnumerable<MultiMapPocoF>>(result);
            True(result.Any());
            Equal(1, result.Count());

            // first record
            var first = result.First();
            Equal(38, first.Id);
            Equal("Multimap: 38", first.Name);
            Equal(52, first.Value);

            // poco A:
            var pocoA = first.PocoA;
            Equal(8, pocoA.PocoA_Id);
            Equal("POCO A: 8", pocoA.Name);
            Equal(22, pocoA.Value);

            // poco B:
            var pocoB = first.PocoB;
            Equal(13, pocoB.PocoB_Id);
            Equal("POCO B: 13", pocoB.Name);
            Equal(27, pocoB.Value);

            // poco C:
            var pocoC = first.PocoC;
            Equal(18, pocoC.PocoC_Id);
            Equal("POCO C: 18", pocoC.Name);
            Equal(32, pocoC.Value);

            // poco D:
            var pocoD = first.PocoD;
            Equal(23, pocoD.PocoD_Id);
            Equal("POCO D: 23", pocoD.Name);
            Equal(37, pocoD.Value);

            // poco E: 
            var pocoE = first.PocoE;
            Equal(28, pocoE.PocoE_Id);
            Equal("POCO E: 28", pocoE.Name);
            Equal(42, pocoE.Value);

            // poco F:
            var pocoF = first.PocoF;
            Equal(33, pocoF.PocoF_Id);
            Equal("POCO F: 33", pocoF.Name);
            Equal(47, pocoF.Value);
        }
    }
}
