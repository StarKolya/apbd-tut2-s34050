// See https://aka.ms/new-console-template for more information

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}