namespace OOPExampleSales.Entities.Product
{
    class Product
    {
        public int ProductCode { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Category Category { get; set; }
        public Department Department { get; set; }

        public Product()
        {
            this.ProductCode = Helpers.IdGenerator.CreateId();
        }

        public override string ToString()
        {
            return 
                $"Product Code: {this.ProductCode} \n" +
                $"Name: {this.Name} \n" +
                $"Price: {this.Price} \n" +
                $"Color: {this.Color} \n" +
                $"Size: {this.Size} \n" +
                $"Category Name: {this.Category.Name} \n" +
                $"Category Code: {this.Category.CategoryCode} \n" +
                $"Department Name: {this.Department.Name} \n" +
                $"Department Code: {this.Department.DepartmentCode} \n";
        }
    }

    enum Color
    {
        Black,
        Red,
        White
    }

    enum Size
    {
        Big,
        Medium,
        Small
    }
}
