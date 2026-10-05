class MultipleConstraints
{
    public static void Process<T>(T item)
        where T : class, IPrintable, new()
    {
        item.Print();
    }
}