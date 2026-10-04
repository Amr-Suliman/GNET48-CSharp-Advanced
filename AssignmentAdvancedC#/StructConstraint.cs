class StructConstraint
{
    public static void PrintValue<T>(T value) where T : struct
    {
        Console.WriteLine(value);
    }
}