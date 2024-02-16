// See https://aka.ms/new-console-template for more information
using ConsoleAppProducts;


class Program
{
    static void Main(string[] args)
    {
        ProductDetails productDetails = new ProductDetails();
        Console.WriteLine("AllProducts");
        DisplayProducts(productDetails.ALLProducts());
        Console.WriteLine("\n Enter product id to search:");
        int id = Convert.ToInt32(Console.ReadLine());
        Product searchResult = productDetails.SearchProduct(id);
        if (searchResult != null)
        {
            Console.WriteLine($"\n Product with Id{id}:");

        }

    }
    static void DisplayProducts(SortedList<int,Product> products)
    {
        foreach (var product in products)
        {
            DisplayProduct(product.Value);
        }
    }

    

    static void DisplayProduct(Product product)
    {
        Console.WriteLine($"ID:{product.PId},Name:{product.PName},Price:{product.PPrice},Brand:{product.PBrand},ManufacturingDate:{product.MfDate.ToShortDateString},ExpiryDate:{product:ExpDate.ToShortDateString()}");

    }
}
        