namespace AssignmentAdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Question 1
            // Q1: What is a generic class? Why use generics?

            // A generic class is a class that can work with different data types
            // without specifying the data type when the class is created.

            // We use generics to:
            // 1. Reuse the same code with different data types.
            // 2. Provide type safety.
            // 3. Avoid unnecessary casting.

            // Example:
            // List<int>
            // List<string>
            #endregion

            #region Question 2

            //Container<int> numbers = new Container<int>();

            //numbers.Add(10);

            //Console.WriteLine(numbers.Get());

            #endregion

            #region Question 3

            //Pair<int, string> student = new Pair<int, string>(1, "Amr");

            //Console.WriteLine(student.Key);
            //Console.WriteLine(student.Value);

            #endregion

            #region Question 4

            //int x = 10;
            //int y = 20;

            //SwapHelper.Swap(ref x, ref y);

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion

            #region Question 5

            //int maxNumber = FindMaxHelper.FindMax(10, 20);
            //Console.WriteLine(maxNumber);

            #endregion

            #region Question 6

            //IRepository<string> repository = new StringRepository();

            //repository.Add("Amr");

            //Console.WriteLine(repository.GetById(1));

            //repository.Delete(1);

            #endregion

        }
    }
}
