public class SimulateAsync {
    public async Task<string> GetInfoAsync() {
        await Task.Delay(2000);
        // Console.WriteLine("Done: Info from async method");
        return "Info from async method";
    }
    public async Task<string> GetInfoAsync(string info) {
        await Task.Delay(3000);
        // Console.WriteLine("Done: Info from async method with parameter");
        return info;
    }
    public async Task<string> GetInfoAsync(string info, int delay) {
        await Task.Delay(delay);
        // Console.WriteLine("Done: Info from async method with parameter and delay");
        return info;
    }
}