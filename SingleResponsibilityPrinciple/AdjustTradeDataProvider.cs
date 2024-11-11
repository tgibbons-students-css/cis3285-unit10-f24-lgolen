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
        public IEnumerable<string> GetTradeData()
        {
            var tradeData = tradeProvider.GetTradeData();

            var newTradeData = tradeData.Select(line => line.Replace("GBP", "EUR"));

            return newTradeData;
        }
    }
}
