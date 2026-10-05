class BaseClassConstraint
{
    public static void PrintName<T>(T person) where T : Person
    {
        Console.WriteLine(person.Name);
    }
}