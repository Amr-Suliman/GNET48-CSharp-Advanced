class Student : Person, IPrintable
{
    public Student()
    {
    }

    public int Grade { get; set; }

    public void Print()
    {
        Console.WriteLine("Student Information");
    }
}