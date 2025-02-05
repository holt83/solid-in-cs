using System.Collections.Generic;
using System.Linq;
using Wincubate.Module1.DomainLayer;

namespace Wincubate.Module1
{
    class Computation
    {
        public IEnumerable<StockPosition> Execute(IEnumerable<StockPosition> inputData)
        {
            return inputData
                .GroupBy(stockPosition => stockPosition.Ticker)
                .Select(group => new StockPosition(
                    group.Key,
                    group.Sum(stockPosition => stockPosition.Size))
                )
                .ToList()
                ;
        }
    }
}
