class InterfaceConstraint
{
    public static void PrintItem<T>(T item) where T : IPrintable
    {
        item.Print();
    }
}