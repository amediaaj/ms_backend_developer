public class DataHandling
{
    public async Task GetDataWithHandling()
    {
        try
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync("https://api.example.com/data");
            Console.WriteLine(data);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }   
    }
}