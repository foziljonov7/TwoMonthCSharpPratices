//Collections

// List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// for(var index = numbers.Count - 1; index >= 0; index--)
// {
//     if(numbers[index] % 2 == 1)
//     {
//         numbers.RemoveAt(index);
//     }
// }

// numbers.ForEach(
//     number => Console.Write(number + " "));

// IteratorThroughList();

// static void IteratorThroughList()
// {
//     var theGalaxies = new List<Galaxy>()
//     {
//         new() {Name = "Tadpole", MegaLightYears = 400},
//         new() {Name = "Ursa Major", MegaLightYears = 2600},
//     };

//     foreach (var Galaxy in theGalaxies) 
//     {
//         Console.WriteLine($"Galaxy: {Galaxy.Name}, MegaLightYears: {Galaxy.MegaLightYears}");   
//     }
// }

// public class Galaxy
// {
//     public string Name { get; set; }
//     public int MegaLightYears { get; set; }
// }



//Dictionary
// BuildDictionary();
// IteratorThruDictionary();

// static void IteratorThruDictionary()
// {
//     Dictionary<string, User> users = BuildDictionary();

//     foreach (KeyValuePair<string, User> user in users)
//     {
//         User theUser = user.Value;

//         Console.WriteLine($"{user.Key}: {theUser.Username}, {theUser.Password}");
//     }
// }

// static Dictionary<string, User> BuildDictionary() =>
//     new ()
//     {
//         {"f",
//             new User { Username = "foziljonov7", Password = "1234" }},
//         {"b",
//             new User { Username = "bahromov", Password = "5678" }},
//         {"a",
//             new User { Username = "aliakbarov", Password = "9012" }}
//     };

// public class User
// {
//     public string Username { get; set; }
//     public string Password { get; set; }
// }


//List & LINQ

// ShowLINQ();

// static void ShowLINQ()
// {
//     List<User> users = BuildUsers();

//     var filterUser = from user in users
//                      where user.Username != null
//                      select user;

//     foreach (var user in filterUser)
//     {
//         Console.WriteLine($"{user.Username}, {user.Password}");
//     }
// }

// static List<User> BuildUsers() => new()
// {
//     new() {Username = "foziljonov7", Password = "1234"},
//     new() {Username = "bahromov", Password = "4321"}
// };


//Queue - navbat

// Queue<int> queue = new Queue<int>();

// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);

// Console.WriteLine(queue.Dequeue());
// Console.WriteLine(queue.Peek());
// Console.WriteLine(queue.Dequeue());
// Console.WriteLine(queue.Dequeue());

//Stack - tashkil
// Stack<int> stack = new Stack<int>();

// stack.Push(1);
// stack.Push(2);
// stack.Push(3);

// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Peek());
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Pop());


//Hashset

// HashSet<int> hashSet = new HashSet<int> {1, 2, 3, 4};

// hashSet.Add(4);
// hashSet.Add(5);

// foreach (var set in hashSet)
//     Console.WriteLine(set);