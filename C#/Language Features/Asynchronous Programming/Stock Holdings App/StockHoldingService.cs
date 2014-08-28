using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHoldingsApp
{
    public class StockHoldingService
    {
        async internal static Task<Tuple<string, int>> GetStockAsync(string userName)
        {
            await Task.Delay(1000);

            switch (userName)
            {
                case "Prasad":
                    return new Tuple<string, int>("MSFT", 100);
                case "Admin":
                    return new Tuple<string, int>("APPL", 500);
                default:
                    break;
            }

            return null;
        }
    }
}
