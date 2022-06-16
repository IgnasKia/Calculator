class UserInputs
{
    public static string GetOperation()
    {
        Console.WriteLine("Choose an operator from the following list:");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide");
        Console.WriteLine("\tr - Residue");
        Console.Write("Your option? ");

        string operation = Console.ReadLine();

        return operation;
    }

    public static double GetNumber()
    {
        string numInput1 = "";
        Console.WriteLine("Type in the the number and press Enter: ");
        numInput1 = Console.ReadLine();

        if (double.TryParse(numInput1, out double value))
        {
            return value;
        }
        else
        {
            Console.WriteLine("That is an invalid number. Please try again.");
            return GetNumber();
        }
    }
}