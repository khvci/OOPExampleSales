namespace OOPExampleSales.Entities.Store
{
    class Store
    {
        public int StoreCode { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public City City { get; set; }
        public Country Country { get; set; }

        public Store()
        {
            this.StoreCode = Helpers.IdGenerator.CreateId();
        }

        public override string ToString()
        {
            return
                $"MAGAZA BILGILERI: \n" +
                $"Store Code: {this.StoreCode} \n" +
                $"Name: {this.Name} \n" +
                $"Address: {this.Address} \n" +
                $"Telephone: {this.Telephone} \n" +
                $"City: {this.City.Name} \n" +
                $"Country: {this.Country.Name} \n";
        }
    }
}
