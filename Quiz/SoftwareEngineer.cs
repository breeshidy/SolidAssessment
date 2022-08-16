namespace Quiz
{
    public class SoftwareEngineer : IEmployee
    {
        public string ReportsTo()
        {
            //Reports to the Software Engineering Manager
            return "Bob";
        }

        public double GetSalary()
        {
            return 35000d;
        }
    }
}
