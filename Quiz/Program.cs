using Quiz;

Console.ForegroundColor = ConsoleColor.Green;
IEmployee softwareEngineer = new SoftwareEngineer();
Console.WriteLine($"As a SoftwareEngineer, I get an annual salary of ${softwareEngineer.GetSalary()} and I report to {softwareEngineer.ReportsTo()}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                                                                         ");

IEmployee manager = new Manager();
Console.WriteLine($"As a manager, I get an annual salary of ${manager.GetSalary()} and I report to {manager.ReportsTo()}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                                                                         ");

//what happens when you try to run these commented lines for the CEO ?
//IEmployee CEO = new CEO();
//Console.WriteLine($"As a CEO, I get an annual salary of ${CEO.GetSalary()} and I report to {CEO.ReportsTo()}");
IBaseEmployee CEO = new CEO();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                                                                         ");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("                                                                                         ");

Console.WriteLine("Do you think the current implementation of IEmployee breaks ISP ? If YES, could you fix it ?");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("                                                                                         ");