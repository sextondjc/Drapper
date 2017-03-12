// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Drapper.Tests.Helpers.CommanderHelper;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [Collection("Integration")]
    public class MultimapAsync
    {
        [Fact]
        public async Task WithTwoTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithTwoParameters);

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
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }

        [Fact]
        public async Task WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithTwoParameters, new { Id = 5 });

                NotNull(result);
                IsAssignableFrom<IEnumerable<MultiMapPocoA>>(result);
                True(result.Any());
                Equal(1, result.Count());

                // first record
                var first = result.First();
                Equal(10, first.Id);
                Equal("Multimap: 10", first.Name);
                Equal(24, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Equal(5, pocoA.PocoA_Id);
                Equal("POCO A: 5", pocoA.Name);
                Equal(19, pocoA.Value);
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }

        [Fact]
        public async Task WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithThreeParameters);
                
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
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(6, pocoB.PocoB_Id);
                Equal("POCO B: 6", pocoB.Name);
                Equal(20, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }

        [Fact]
        public async Task WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithThreeParameters, new { Id = 5 });

                NotNull(result);
                IsAssignableFrom<IEnumerable<MultiMapPocoB>>(result);
                True(result.Any());
                Equal(1, result.Count());

                // first record
                var first = result.First();
                Equal(15, first.Id);
                Equal("Multimap: 15", first.Name);
                Equal(29, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Equal(5, pocoA.PocoA_Id);
                Equal("POCO A: 5", pocoA.Name);
                Equal(19, pocoA.Value);
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(10, pocoB.PocoB_Id);
                Equal("POCO B: 10", pocoB.Name);
                Equal(24, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFourParameters);

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
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(6, pocoB.PocoB_Id);
                Equal("POCO B: 6", pocoB.Name);
                Equal(20, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(11, pocoC.PocoC_Id);
                Equal("POCO C: 11", pocoC.Name);
                Equal(25, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFourParameters, new { Id = 5 });

                NotNull(result);
                IsAssignableFrom<IEnumerable<MultiMapPocoC>>(result);
                True(result.Any());
                Equal(1, result.Count());

                // first record
                var first = result.First();
                Equal(20, first.Id);
                Equal("Multimap: 20", first.Name);
                Equal(34, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Equal(5, pocoA.PocoA_Id);
                Equal("POCO A: 5", pocoA.Name);
                Equal(19, pocoA.Value);
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(10, pocoB.PocoB_Id);
                Equal("POCO B: 10", pocoB.Name);
                Equal(24, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(15, pocoC.PocoC_Id);
                Equal("POCO C: 15", pocoC.Name);
                Equal(29, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFiveParameters);

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
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(6, pocoB.PocoB_Id);
                Equal("POCO B: 6", pocoB.Name);
                Equal(20, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(11, pocoC.PocoC_Id);
                Equal("POCO C: 11", pocoC.Name);
                Equal(25, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Equal(16, pocoD.PocoD_Id);
                Equal("POCO D: 16", pocoD.Name);
                Equal(30, pocoD.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

            }
        }

        [Fact]
        public async Task WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFiveParameters, new { Id = 5 });

                NotNull(result);
                IsAssignableFrom<IEnumerable<MultiMapPocoD>>(result);
                True(result.Any());
                Equal(1, result.Count());

                // first record
                var first = result.First();
                Equal(25, first.Id);
                Equal("Multimap: 25", first.Name);
                Equal(39, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Equal(5, pocoA.PocoA_Id);
                Equal("POCO A: 5", pocoA.Name);
                Equal(19, pocoA.Value);
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(10, pocoB.PocoB_Id);
                Equal("POCO B: 10", pocoB.Name);
                Equal(24, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(15, pocoC.PocoC_Id);
                Equal("POCO C: 15", pocoC.Name);
                Equal(29, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Equal(20, pocoD.PocoD_Id);
                Equal("POCO D: 20", pocoD.Name);
                Equal(34, pocoD.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSixParameters);

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
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(6, pocoB.PocoB_Id);
                Equal("POCO B: 6", pocoB.Name);
                Equal(20, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(11, pocoC.PocoC_Id);
                Equal("POCO C: 11", pocoC.Name);
                Equal(25, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Equal(16, pocoD.PocoD_Id);
                Equal("POCO D: 16", pocoD.Name);
                Equal(30, pocoD.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Equal(21, pocoE.PocoE_Id);
                Equal("POCO E: 21", pocoE.Name);
                Equal(35, pocoE.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSixParameters, new { Id = 5 });

                NotNull(result);
                IsAssignableFrom<IEnumerable<MultiMapPocoE>>(result);
                True(result.Any());
                Equal(1, result.Count());

                // first record
                var first = result.First();
                Equal(30, first.Id);
                Equal("Multimap: 30", first.Name);
                Equal(44, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Equal(5, pocoA.PocoA_Id);
                Equal("POCO A: 5", pocoA.Name);
                Equal(19, pocoA.Value);
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(10, pocoB.PocoB_Id);
                Equal("POCO B: 10", pocoB.Name);
                Equal(24, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(15, pocoC.PocoC_Id);
                Equal("POCO C: 15", pocoC.Name);
                Equal(29, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Equal(20, pocoD.PocoD_Id);
                Equal("POCO D: 20", pocoD.Name);
                Equal(34, pocoD.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Equal(25, pocoE.PocoE_Id);
                Equal("POCO E: 25", pocoE.Name);
                Equal(39, pocoE.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSevenParameters);

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
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(6, pocoB.PocoB_Id);
                Equal("POCO B: 6", pocoB.Name);
                Equal(20, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(11, pocoC.PocoC_Id);
                Equal("POCO C: 11", pocoC.Name);
                Equal(25, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Equal(16, pocoD.PocoD_Id);
                Equal("POCO D: 16", pocoD.Name);
                Equal(30, pocoD.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Equal(21, pocoE.PocoE_Id);
                Equal("POCO E: 21", pocoE.Name);
                Equal(35, pocoE.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                Equal(26, pocoF.PocoF_Id);
                Equal("POCO F: 26", pocoF.Name);
                Equal(40, pocoF.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSevenParameters, new { Id = 5 });

                NotNull(result);
                IsAssignableFrom<IEnumerable<MultiMapPocoF>>(result);
                True(result.Any());
                Equal(1, result.Count());

                // first record
                var first = result.First();
                Equal(35, first.Id);
                Equal("Multimap: 35", first.Name);
                Equal(49, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Equal(5, pocoA.PocoA_Id);
                Equal("POCO A: 5", pocoA.Name);
                Equal(19, pocoA.Value);
                Equal(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Equal(10, pocoB.PocoB_Id);
                Equal("POCO B: 10", pocoB.Name);
                Equal(24, pocoB.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Equal(15, pocoC.PocoC_Id);
                Equal("POCO C: 15", pocoC.Name);
                Equal(29, pocoC.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Equal(20, pocoD.PocoD_Id);
                Equal("POCO D: 20", pocoD.Name);
                Equal(34, pocoD.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Equal(25, pocoE.PocoE_Id);
                Equal("POCO E: 25", pocoE.Name);
                Equal(39, pocoE.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                Equal(30, pocoF.PocoF_Id);
                Equal("POCO F: 30", pocoF.Name);
                Equal(44, pocoF.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }

    }
}
