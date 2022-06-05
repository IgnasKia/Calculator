class Program
{
    static void Main(string[] args)
    {
        bool endCalculation = false;

        while (!endCalculation)
        {
            double number1 = UserInputs.GetNumber();
            double number2 = UserInputs.GetNumber();
            string operation = UserInputs.GetOperation();
            try
            {
                double result = Calculator.DoOperation(number1, number2, operation);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred trying to do the math.\n - Details: " + e.Message);
            }

            endCalculation = StartOver.ProcessState();

            Console.Clear();
        }

    }
}