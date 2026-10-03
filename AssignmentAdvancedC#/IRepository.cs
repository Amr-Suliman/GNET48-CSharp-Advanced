interface IRepository<T>
{
    void Add(T item);

    T GetById(int id);

    void Delete(int id);
}