using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Repositories
{
    public interface ICurrencyRepository : IDisposable
    {
        Currency Create(Currency model);

        Currency Delete(Currency model);

        Currency Update(Currency model);

        Currency Retrieve(string numericCode);

        PagedResult<Currency> RetrieveAll(int page = 1, int size = 10);
    }
}
