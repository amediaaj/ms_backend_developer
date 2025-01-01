public class ReadFile {
    public async Task<string> ReadFileAsync(string path) {
        using (StreamReader reader = new StreamReader(path)) {
            string content =  await reader.ReadToEndAsync();
            return content;
        }
    }
}       