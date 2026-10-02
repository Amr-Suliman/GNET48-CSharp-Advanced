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

        }
    }
}
