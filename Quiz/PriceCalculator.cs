using Quiz.Fruits;

namespace Quiz
{
    internal class PriceCalculator 
    {
        //What do you think about this method ?
        //Should this be a responsibility of this Basket Class ?
        public double GetTotalCost(IDictionary<int, Fruit> fruits)
        {
            double cost = 0;
      
            foreach (var fruit in fruits)
            {
                cost += fruit.Value.Cost;
            }

            return cost;
        }
    }
}
