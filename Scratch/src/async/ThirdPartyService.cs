public class ThirdPartyService
{
    public async Task FetchDataUsingAsyncAwait()
    {
        Task task1 = FetchDataFromAPIAsync("https://api.example.com/data1");
        Task task2 = FetchDataFromAPIAsync("https://api.example.com/data2");
        Task task3 = FetchDataFromAPIAsync("https://api.example.com/data3");

        await Task.WhenAll(task1, task2, task3); // Await all tasks to complete
    }        
    public void FetchDataUsingThreads()
    {
        Thread thread1 = new Thread(() => FetchDataFromAPI("https://api.example.com/data1"));
        Thread thread2 = new Thread(() => FetchDataFromAPI("https://api.example.com/data2"));
        Thread thread3 = new Thread(() => FetchDataFromAPI("https://api.example.com/data3"));

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join(); // Wait for thread1 to complete
        thread2.Join(); // Wait for thread2 to complete
        thread3.Join(); // Wait for thread3 to complete
    }

        public List<Thread> FetchReturnThreads()
    {
        Thread thread1 = new Thread(() => FetchDataFromAPI("https://api.example.com/data1"));
        Thread thread2 = new Thread(() => FetchDataFromAPI("https://api.example.com/data2"));
        Thread thread3 = new Thread(() => FetchDataFromAPI("https://api.example.com/data3"));

        thread1.Start();
        thread2.Start();
        thread3.Start();

        List<Thread> threads = new List<Thread> {thread1, thread2, thread3};
        return threads;
    }

     private async Task FetchDataFromAPIAsync(string url)
    {
        // Simulate asynchronous network call
        await Task.Delay(2000); // Simulating a 2-second delay (API response time)
        Console.WriteLine($"Data fetched from {url} using async/await");
    }
    
    private void FetchDataFromAPI(string url)
    {
        // Simulate network call
        Thread.Sleep(2000); // Simulating a 2-second delay (API response time)
        Console.WriteLine($"Data fetched from {url} using threads");
    }
}