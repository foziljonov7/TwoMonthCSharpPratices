//Async & await
// async Task<int> GetNumberWithExceptionHandlingAsync()
// {
//     try
//     {
//         await Task.Delay(1000);
//         return 100;
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Error: {ex.Message}");
//         return -1;
//     }
// }

// int res = await GetNumberWithExceptionHandlingAsync();
// Console.WriteLine(res);

//Task - parallel

// async void DoSomeWork()
// {
//     Task.Delay(1000).Wait();
//     Console.WriteLine("Do some work");
// }
// async void DoSomeOtherWork()
// {
//     Task.Delay(500).Wait();
//     Console.WriteLine("Do some other work");
// }

// Parallel.Invoke(() => DoSomeWork(), () => DoSomeOtherWork());

// Task t1 = Task.Run(() => PerformTask(1));
// Task t2 = Task.Run(() => PerformTask(2));
// Task t3 = Task.Run(() => PerformTask(3));

// await Task.WhenAll(t1, t2, t3);
// Console.WriteLine("All tasks completed");

// static void PerformTask(int id)
// {
//     Console.WriteLine($"Task {id} is running");
//     Task.Delay(1000).Wait();
//     Console.WriteLine($"Task {id} is completed");
// }

//Task library
// Parallel.For(0, 10, i =>
// {
//     Console.WriteLine($"Element {i} ni qayta ishlash {Task.CurrentId}");
//     Task.Delay(100).Wait();
// });

// Console.WriteLine("Barchasi qayta ishlandi.");

//IAsyncEnumrable<T>

// await foreach(var number in GeneratorAsync())
//     Console.WriteLine(number);

// static async IAsyncEnumerable<int> GeneratorAsync()
// {
//     for(int i = 0; i <= 10; i++)
//     {
//         await Task.Delay(1000);
//         yield return i;
//     }
// }
