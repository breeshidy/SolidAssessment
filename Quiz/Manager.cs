namespace Quiz
{
    public class Manager : IEmployee
    {
        public string ReportsTo()
        {
            //Reports to the CEO
            return "Rahmat";
        }

        public double GetSalary()
        {
            return 80000d;
        }
    }
}
