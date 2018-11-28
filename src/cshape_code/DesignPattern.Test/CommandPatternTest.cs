using NUnit.Framework;
using System;
using DesignPattern.CommandPattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class CommandPatternTest
    {
        [Test()]
        public void CommandPatternDemo()
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrder();
        }
    }
}
