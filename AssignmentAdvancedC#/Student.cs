class Student : IPrintable
{
    public Student()
    {
    }

    public string Name { get; set; }

    public void Print()
    {
        Console.WriteLine("Student Information");
    }
}