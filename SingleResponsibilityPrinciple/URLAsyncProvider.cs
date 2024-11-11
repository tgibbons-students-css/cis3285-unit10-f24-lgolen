using SingleResponsibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class URLAsyncProvider : ITradeDataProvider
    {
        ITradeDataProvider tradeProvider;

        public URLAsyncProvider(ITradeDataProvider tradeProvider)
        {
            this.tradeProvider = tradeProvider;
        }

        public Task<IEnumerable<string>> GetTradeAsync()
        {
            Task<IEnumerable<string>> task = Task.Run(() => tradeProvider.GetTradeData());
            return task;
        }
        public async Task<IEnumerable<string>> GetTradeData()
        {
            //Task<IEnumerable<string>> task =  GetTradeAsync();
            return await GetTradeAsync();
        }
    }
}
