using System;
using System.Linq;
using Sample.Models;
using Drapper;
using static Drapper.Validation.Validator;
using System.Collections.Generic;

namespace Sample.Repositories
{
    public sealed class CurrencyRepository : ICurrencyRepository
    {
        private readonly IDbCommander _commander;

        public CurrencyRepository(IDbCommander commander)
        {
            _commander = commander;
        }

        public Currency Create(Currency model)
        {
            Validate(model);
            return _commander.Execute(model) ? model : null;
        }

        public Currency Delete(Currency model)
        {
            Validate(model);
            return _commander.Execute(model) ? model : null;
        }
        
        public Currency Retrieve(string numericCode)
        {
            return _commander.Query<Currency>(new { numericCode }).SingleOrDefault();
        }

        public PagedResult<Currency> RetrieveAll(int page = 1, int size = 10)
        {
            return _commander.Query(Map.PagedCurrency, new { page, size }).SingleOrDefault();
        }

        public Currency Update(Currency model)
        {
            Validate(model);
            return _commander.Execute(model) ? model : null;
        }

        public void Dispose()
        {
            _commander.Dispose();
        }

        private static class Map
        {
            /// <summary>
            /// Mapping function to support mapping the pagination data 
            /// and the paginated values into a collection for returning 
            /// to the Query call. 
            /// </summary>
            internal static
                Func<IEnumerable<Pagination>,
                IEnumerable<Currency>,
                IEnumerable<PagedResult<Currency>>> PagedCurrency = (pages, currencies) =>
                {
                    return new List<PagedResult<Currency>>
                    {
                        new PagedResult<Currency>
                        {
                            Meta = pages.SingleOrDefault(),
                            Values = currencies
                        }
                    };
                };
        }
    }
}
