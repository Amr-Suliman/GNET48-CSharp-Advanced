class StringRepository : IRepository<string>
{
    public void Add(string item)
    {
        Console.WriteLine($"Added: {item}");
    }

    public string GetById(int id)
    {
        return $"Item with ID: {id}";
    }

    public void Delete(int id)
    {
        Console.WriteLine($"Deleted item with ID: {id}");
    }
}