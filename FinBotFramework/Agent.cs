using System;
using System.Threading.Tasks;

namespace FinBotNet
{
    public class Agent
    {
        public Guid Id { get; set; }
        public Account Account { get; set; }
        public Strategy Strat { get; set; }

        public async Task Tick(DateTime time)
        {
            var order = await Strat.Evaluate(time, Account);
            if (order.Volume != 0)
                await Account.Place(order);
        }
    }
}
