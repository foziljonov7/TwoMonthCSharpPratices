using ThreeWeek.Advanced;

//interface
// Circle circle = new Circle();
// circle.Width = 4;
// circle.Height = 4;

// Console.WriteLine(circle.Perimeter());


//Delegates
// public delegate void MyDelegate(string message);

// class Program
// {
//     static void Main(string[] args)
//     {
//         MyDelegate del = ClassA.MethodA;
//         del("Hello world!");

//         del = ClassB.MethodB;
//         del("Hello world!");

//         del = (string message) => Console.WriteLine("Lambda ifoda ishga tushurildi!");
//         del("Hello world");
//     }
// }

// public delegate T add<T>(T t1, T t2);

// class Program
// {
//     static void Main(string[] args)
//     {
//         add<int> sum = Sum;
//         Console.WriteLine(sum(10, 50));

//         add<string> sum2 = Sum;
//         Console.WriteLine(sum2("Hello ", "World!"));        
//    }

//     public static int Sum(int t1, int t2)
//     {
//         return t1 + t2;
//     }

//     public static string Sum(string t1, string t2)
//     {
//         return t1 + t2;
//     }
// }


//Func delegate
// Func<int, bool> add = IsOdd;
// int number = int.Parse(Console.ReadLine());

// bool result = add(number);

// Console.WriteLine($"Output: {number} toqligi {result}");


// static bool IsOdd(int n) => n % 2 == 1;


//Anonim delegate

// class Program
// {
//     public delegate void Print(string s); // Print nomli delegatni aniqlaymiz
//     static void Main(string[] args)
//     {
//         // Print delegatini lambdani ifodalaymiz
//         Print print;
//         print = delegate(string s) 
//         {
//             Console.WriteLine($"Hello {s}");
//         };

//         // Delegatni chaqiramiz
//         print("Uzbekistan");
//     }
// }


// Publisher publisher = new Publisher();

// Subscriber subscriber1 = new Subscriber("Subscriber 1");
// Subscriber subscriber2 = new Subscriber("Subscriber 2");

// publisher.Notify += subscriber1.OnNotifyReceived;
// publisher.Notify += subscriber2.OnNotifyReceived;

// publisher.DoSomething();

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine(GetInt(array, 9));

int GetInt(int[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (IndexOutOfRangeException ex) when (index < 0)
    {
        throw new ArgumentOutOfRangeException("Parameter index out of range", ex);
    }
    catch(IndexOutOfRangeException ex)
    {
        throw new ArgumentOutOfRangeException("Parameter index cannot be greater than the array size.", ex);
    }
}