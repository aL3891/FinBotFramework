using System;
using System.Threading.Tasks;

namespace FinBotNet
{
    public class Strategy
    {

        public Guid Id { get; set; }

        public async Task<Order> Evaluate(DateTime time, Account account)
        {
            return null;
        }
    }
}
