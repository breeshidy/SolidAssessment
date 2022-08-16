namespace Quiz
{
    public class CEO : IEmployee
    {
        public string ReportsTo()
        {
            //As I am the CEO, I don't report to anyone.
            //so can't implement any logic for this method
            throw new NotImplementedException();
        }

        public double GetSalary()
        {
            return 100000d;
        }
    }
}
