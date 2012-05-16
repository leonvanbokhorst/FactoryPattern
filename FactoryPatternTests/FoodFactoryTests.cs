using System.Linq;
using System.Reflection;
using FactoryPattern.Food;
using FactoryPattern.FoodFactories;
using FactoryPatternTests.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryPatternTests
{
    [TestClass]
    public class FoodFactoryTests
    {
        [TestMethod]
        public void CreateSomeFood()
        {
            IFoodFactory factory = CreateFoodFactory();
            IFood food = factory.CreateFood();
            food.EatIt();
        }

        private IFoodFactory CreateFoodFactory()
        {
            string factoryName = Settings.Default.FoodFactory.Trim();
            Assembly assembly = Assembly.Load(factoryName.Split('.').First());
            object instance = assembly.CreateInstance(factoryName);

            return (IFoodFactory) instance;
        }
    }
}