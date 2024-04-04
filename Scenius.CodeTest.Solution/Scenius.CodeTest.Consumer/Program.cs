// See https://aka.ms/new-console-template for more information

Random randGenerator = new Random();        // Create once, use many times
Console.WriteLine(Calculate());

 double Calculate()
{
    return randGenerator.NextDouble() * 100000;
}