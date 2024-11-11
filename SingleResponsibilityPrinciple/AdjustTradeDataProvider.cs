using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class AdjustTradeDataProvider : ITradeDataProvider
    {
        ITradeDataProvider tradeProvider;

        public AdjustTradeDataProvider(ITradeDataProvider tradeProvider)
        {
            this.tradeProvider = tradeProvider;
        }
        public async Task<IEnumerable<string>> GetTradeData()
        {
            var tradeData = await tradeProvider.GetTradeData();

            var newTradeData = tradeData.Select(line => line.Replace("GBP", "EUR"));

            return newTradeData;
        }
    }
}
