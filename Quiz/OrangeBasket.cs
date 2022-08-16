namespace Quiz
{
    public class OrangeBasket
    {
        private readonly IDictionary<int, Orange> _oranges;

        public OrangeBasket()
        {
            _oranges = new Dictionary<int, Orange>();
        }

        public Orange Get(int id)
        {
            return _oranges[id];
        }

        public void Add(Orange orange)
        {
            _oranges.Add(orange.Id, orange);
        }

        public void Remove(Orange orange)
        {
            _oranges.Remove(orange.Id);
        }

        //What do you think about this method ?
        //Should this be a responsibility of this Basket Class ?
        public double GetTotalCost()
        {
            double cost = 0;
            foreach(var orange in _oranges)
            {
                cost += orange.Value.Cost;
            }

            return cost;
        }
    }
}