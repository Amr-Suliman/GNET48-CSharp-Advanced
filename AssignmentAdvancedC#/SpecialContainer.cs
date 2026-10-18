class SpecialContainer<T> : Container<T>
{
    public void Show()
    {
        Console.WriteLine(Get());
    }
}