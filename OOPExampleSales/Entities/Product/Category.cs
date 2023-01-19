namespace OOPExampleSales.Entities.Product
{
    class Category
    {
        public int CategoryCode { get; }
        public string Name { get; set; }

        public Category()
        {
            this.CategoryCode = Helpers.IdGenerator.CreateId();
        }

    }
}
