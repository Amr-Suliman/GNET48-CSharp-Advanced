class ClassConstraint
{
    public static void PrintValue<T>(T value) where T : class
    {
        Console.WriteLine(value);
    }
}