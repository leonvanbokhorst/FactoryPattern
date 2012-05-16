using System.Diagnostics;

namespace FactoryPattern.Food
{
    public class BioPotatoes : IFood
    {
        #region IFood Members

        public void EatIt()
        {
            Debug.WriteLine(
                "Eating Bio Potatoes. Feeling healthy and a nice person.");
        }

        #endregion
    }
}