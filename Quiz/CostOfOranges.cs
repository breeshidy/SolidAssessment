namespace Quiz
{
    internal class CostOfOranges : OrangeBasket
    {
        //What do you think about this method ?
        //Should this be a responsibility of this Basket Class ?
        public double GetTotalCost()
        {
            double cost = 0;
            foreach (var orange in _oranges)
            {
                cost += orange.Value.Cost;
            }

            return cost;
        }
    }
}
