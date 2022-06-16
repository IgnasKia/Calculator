class StartOver
{

    public static bool ProcessState()
    {
        Console.Write("If you want to end calculation then press y and ENTER , or press other key to continue: ");
        return (Console.ReadLine() == "y") ? true : false;
    }
}