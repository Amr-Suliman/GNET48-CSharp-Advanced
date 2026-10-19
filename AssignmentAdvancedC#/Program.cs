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

            #region Question 7

            //StructConstraint.PrintValue(10);

            //StructConstraint.PrintValue(3.14);

            #endregion

            #region Question 8

            //ClassConstraint.PrintValue("Amr");

            #endregion

            #region Question 9

            //Student student = NewConstraint.CreateObject<Student>();
            //student.Name = "Amr";
            //Console.WriteLine(student.Name);

            #endregion

            #region Question 10

            //Student student = new Student();

            //InterfaceConstraint.PrintItem(student);

            #endregion

            #region Question 11

            //Student student = new Student();

            //student.Name = "Amr";

            //BaseClassConstraint.PrintName(student);

            #endregion

            #region Question 12

            //Student student = new Student();

            //MultipleConstraints.Process(student);

            #endregion

            #region Question 13

            //int number = DefaultHelper.GetDefault<int>();

            //string text = DefaultHelper.GetDefault<string>();

            //Console.WriteLine(number);
            //Console.WriteLine(text == null);

            #endregion

            #region Question 14

            //SafeList<int> numbers = new SafeList<int>();

            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);

            //Console.WriteLine(numbers.Get(1));
            //Console.WriteLine(numbers.Get(10));

            #endregion

            #region Question 15

            //ICreator<Dog> dogCreator = new DogCreator();

            //ICreator<Animal> animalCreator = dogCreator;

            //Animal animal = animalCreator.Create();

            //Console.WriteLine(animal.GetType().Name);

            #endregion

            #region Question 16

            //IHandler<Animal> animalHandler = new AnimalHandler();

            //IHandler<Dog> dogHandler = animalHandler;

            //Dog dog = new Dog();

            //dogHandler.Handle(dog);

            #endregion

            #region Question 17

            //What is the difference between covariance and contravariance?
            // Covariance (out):
            // Allows using a more derived type where a less derived type is expected.
            // Used for output (return) types.
            // Example: IEnumerable<string> can be assigned to IEnumerable<object>.

            // Contravariance (in):
            // Allows using a less derived type where a more derived type is expected.
            // Used for input (parameter) types.
            // Example: Action<object> can be assigned to Action<string>.

            // Covariance Example:
            //IEnumerable<string> names = new List<string> { "Amr", "Ahmed" };
            //IEnumerable<object> objects = names;

            //// Contravariance Example:
            //Action<object> printObject = obj => Console.WriteLine(obj);
            //Action<string> printString = printObject;

            //printString("Hello Amr");

            #endregion

            #region Question 18

            //How do static members work in generic types ?

            // Static members in generic types are shared among all instances
            // of the same closed generic type.

            // Each different type argument has its own copy of static members.
            // For example, Counter<int> and Counter<string>
            // have separate static fields.

            //class Counter<T>
            //        {
            //            public static int Count = 0;

            //            public Counter()
            //            {
            //                Count++;
            //            }
            //        }

            //        // Example Usage:
            //        Counter<int> c1 = new Counter<int>();
            //        Counter<int> c2 = new Counter<int>();

            //        Counter<string> c3 = new Counter<string>();

            //        Console.WriteLine(Counter<int>.Count);    // Output: 2
            //Console.WriteLine(Counter<string>.Count); // Output: 1

            #endregion

            #region Question 19

            //SpecialContainer<string> container = new SpecialContainer<string>();

            //container.Add("Amr");

            //container.Show();

            #endregion

            #region Question 20

            //Cache<int, string> products = new Cache<int, string>();

            //products.Add(101, "Laptop", TimeSpan.FromSeconds(5));
            //products.Add(102, "Mouse", TimeSpan.FromMinutes(2));

            //Console.WriteLine(products.Get(101));

            //Console.WriteLine(products.Contains(102));

            //Console.WriteLine(products.Remove(102));

            //Console.WriteLine(products.Contains(102));

            //Thread.Sleep(6000);

            //Console.WriteLine(products.Contains(101));

            //Console.WriteLine(products.Get(101) == null);

            #endregion

        }
    }
}
