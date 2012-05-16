using FactoryPattern.Food;

namespace FactoryPattern.FoodFactories
{
    public class FastFoodFactory : IFoodFactory
    {
        #region IFoodFactory Members

        public IFood CreateFood()
        {
            return new CurlyFries();
        }

        #endregion
    }
}