using FactoryPattern.Food;

namespace FactoryPattern.FoodFactories
{
    public interface IFoodFactory
    {
        // This method is often called CreateInstance
        IFood CreateFood();
    }
}