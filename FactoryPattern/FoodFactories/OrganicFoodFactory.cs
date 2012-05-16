using FactoryPattern.Food;

namespace FactoryPattern.FoodFactories
{
    public class OrganicFoodFactory : IFoodFactory
    {
        #region IFoodFactory Members

        public IFood CreateFood()
        {
            return new BioPotatoes();
        }

        #endregion
    }
}