using OOPExampleSales.Entities;
using OOPExampleSales.Entities.Product;
using OOPExampleSales.Entities.Store;

class Program
{
    public static void Main(string[] args)
    {
        Category furniture = new Category();
        furniture.Name = "Mobilya";

        Department sales = new Department();
        sales.Name = "Satış";

        Product sandalye = new Product();
        sandalye.Name = "Sandalye";
        sandalye.Price = 250;
        sandalye.Color = Color.Red;
        sandalye.Size = Size.Medium;
        sandalye.Category = furniture;
        sandalye.Department = sales;
        //Console.WriteLine(sandalye.ToString());

        

        City istanbul = new City();
        istanbul.Name = "Istanbul";

        Country turkiye = new Country();
        turkiye.Name = "Turkiye";

        Store kadikoyStore = new Store();
        kadikoyStore.Name = "Kadikoy Subesi";
        kadikoyStore.City = istanbul;
        kadikoyStore.Country = turkiye;
        kadikoyStore.Telephone = "2163557845";
        kadikoyStore.Address = "Boga Heykel Karsisi";

        //Console.WriteLine(kadikoyStore.ToString());
        

        Sale sale1= new Sale();
        sale1.Store = kadikoyStore;

        sale1.AddToBasket(sandalye);

        Console.WriteLine(sale1.ToString());
    }
}