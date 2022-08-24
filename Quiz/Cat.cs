namespace Quiz
{
    public class Cat : IAnimal
    {
        public string GetName() => nameof(Cat);

        public string GetHabitat() => "Home";
    }
}
