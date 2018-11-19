using NUnit.Framework;
using System;
using DesignPattern.BuilderPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class BuilderPatternTest
    {
        [Test()]
        public void BuilderPatternDemo()
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.PrepareVegMeal();
            vegMeal.ShowItem();
            Console.WriteLine("COST:" + vegMeal.GetCost());

            Meal noVegMeal = mealBuilder.PrepareNonVegMeal();
            noVegMeal.ShowItem();
            Console.WriteLine("COST:" + noVegMeal.GetCost());
        }
    }
}
