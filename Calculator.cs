// See https://aka.ms/new-console-template for more information
namespace ConsoleCalculator;

internal static class Calculator
{
    public static void Main(string[] args)
    {
        var helper = new IoHelper();
        helper.WriteLine("Please enter a number: ");
        double num1 = double.Parse(helper.ReadLine());
        helper.WriteLine("Please enter a operation: ");
        string operation = helper.ReadLine();
        helper.WriteLine("Please enter a number: ");
        double num2 = double.Parse(helper.ReadLine());
        try
        {
            double result = operation switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num1 / num2,
                "%" => num1 % num2,
                _ => throw new Exception("Invalid operation")
            };
            Console.WriteLine("The result is: " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}