namespace Quiz
{
    public class OrangeBasket 
    {
        public readonly IDictionary<int, Orange> _oranges;

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
    }
}