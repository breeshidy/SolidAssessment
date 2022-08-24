using Quiz;

IAnimal animal = new Lion();
Console.WriteLine($"I am a {animal.GetName()} and I live in the {animal.GetHabitat()}.");

animal = new Cat();
Console.WriteLine($"I am a {animal.GetName()} and I live in the {animal.GetHabitat()}.");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                                                                         ");

Console.WriteLine("Do you think the relationship between Base Class Cat & Sub-Class Lion breaks LSP ?");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                                                                         ");

Console.WriteLine("What happens when an instance of Lion is set to a Cat reference, will the code still behave as it is now ?");


Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("                                                                                         ");
