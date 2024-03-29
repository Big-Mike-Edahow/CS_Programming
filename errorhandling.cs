// ErrorHandling Project

Console.Title = "ErrorHandling";

try
{
    Console.Write("Please Enter A Number: ");
    double num1 = Convert.ToInt16(Console.ReadLine());

    Console.Write("Now Enter Another Number: ");
    double num2 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Total: " + (num1 + num2));
}
catch (OverflowException)
{
    Console.WriteLine("\nMaximum Value: " + Int16.MaxValue);
}

Console.ReadKey();
