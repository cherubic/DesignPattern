using System;
using System.Collections.Generic;
namespace DesignPattern.BuilderPattern
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public Meal()
        {
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (var item in items)
            {
                cost += item.Price();
            }

            return cost;
        }

        public void ShowItem()
        {
            foreach (var item in items)
            {
                Console.WriteLine("Item :" + item.Name());
                Console.WriteLine("Item :" + item.Packing().Pack());
                Console.WriteLine("Item :" + item.Price());
            }
        }
    }
}
