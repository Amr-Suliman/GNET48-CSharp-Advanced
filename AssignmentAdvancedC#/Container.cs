class Container<T>
{
    private T value;

    public void Add(T item)
    {
        value = item;
    }

    public T Get()
    {
        return value;
    }
}