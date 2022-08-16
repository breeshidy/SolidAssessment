namespace Quiz
{
    public class Cat
    {
        public virtual string GetName() => nameof(Cat);

        public virtual string GetHabitat() => "Home";
    }

    public class Lion : Cat
    {
        public override string GetName() => nameof(Lion);

        public override string GetHabitat() => "Wild";
    }
}
