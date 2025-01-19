using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/products")]
[ApiController]
public class ProductController : ControllerBase {
    private static List<Product> products = new List<Product>();

    // GET: Retrieve all products
    [HttpGet]
    public ActionResult<List<Product>> GetAll () => products;

    // GET by Id:  Retrieve a single product by Id
    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id) {
        var product = products.FirstOrDefault(p => p.Id == id);
        return product != null ? Ok(product) : NotFound(); // Blank 1 and 2
    }

    // POST: Add a new product
    [HttpPost]
    public ActionResult<Product> Create(Product newProduct) {
        newProduct.Id = products.Count + 1;
        products.Add(newProduct);
        return CreatedAtAction(nameof(GetById), new { id = newProduct.Id}, newProduct); // Blank 3
    }

    // PUT: Update an existing product
    [HttpPut("{id}")]
    public ActionResult Update(int id, Product updatedProduct) {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound(); // Blank 4

        product.Name = updatedProduct.Name;
        product.Description = updatedProduct.Description;
        product.Price = updatedProduct.Price;
        return Ok(product); // Blank 5
    }

    // DELETE Remove a product
    [HttpDelete("{id}")]
    public ActionResult Delete(int id) {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound(); // Blank 6

        products.Remove(product);
        return NoContent(); // Blank 7
    }
}