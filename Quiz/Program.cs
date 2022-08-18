using Quiz;

IAnimal cat = new Lion();
Console.WriteLine($"I am a {cat.GetName()} and I live in the {cat.GetHabitat()}.");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                                                                         ");

Console.WriteLine("Do you think the relationship between Base Class Cat & Sub-Class Lion breaks LSP ?");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                                                                         ");

Console.WriteLine("What happens when an instance of Lion is set to a Cat reference, will the code still behave as it is now ?");


Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("                                                                                         ");
