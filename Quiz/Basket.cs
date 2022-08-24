namespace Quiz
{
    public class Basket 
    {
        public readonly IDictionary<int, Fruit> _fruits;

        public Basket()
        {
            _fruits = new Dictionary<int, Fruit>();
        }

        public Fruit Get(int id)
        {
            return _fruits[id];
        }

        public void Add(Fruit orange)
        {
            _fruits.Add(orange.Id, orange);
        }

        public void Remove(Fruit orange)
        {
            _fruits.Remove(orange.Id);
        }
    }
}