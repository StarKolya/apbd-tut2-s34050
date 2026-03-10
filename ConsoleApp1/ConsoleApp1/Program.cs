// See https://aka.ms/new-console-template for more information

//I've added some comments for the rebase to work properly

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}


static double CalculateAverage(int[] values)
{
    return values.Sum() / values.Length;
}

static double CalculateMax(int[] values)
{
    return values.Max();
}


// Here I will implement the Calculate min function 
static double CalculateMin(int[] values)
{
    
}