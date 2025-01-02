using Newtonsoft.Json;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }  
    public List<string> Tags { get; set; }  
}

public class Program
{
    public static void Main(string[] args)
    {
      string json = "{\"Name\":\"Apple\",\"Price\":3.99,\"Tags\":[\"Fruit\",\"Organic\"]}";
      Product price = JsonConvert.DeserializeObject<Product>(json);
      Console.WriteLine($"Name: {price.Name}, Price: {price.Price}, Tags: {string.Join(", ", price.Tags)}");  

      Product newProduct = new Product
      {
          Name = "Banana",
          Price = 2.99m,
          Tags = new List<string> { "Fruit", "Organic" }
      };
      Console.WriteLine(JsonConvert.SerializeObject(newProduct));

    }
}