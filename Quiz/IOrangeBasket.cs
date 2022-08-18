namespace Quiz
{
    public interface IOrangeBasket
    {
        void Add(Orange orange);
        Orange Get(int id);
        void Remove(Orange orange);
    }
}