using System;
namespace DesignPattern.CommandPattern
{
    public class SellStock : Order
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Execute()
        {
            abcStock.Sell();
        }
    }
}
