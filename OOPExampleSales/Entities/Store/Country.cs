namespace OOPExampleSales.Entities.Store
{
    class Country
    {
        public int CountryCode { get; }
        public string Name { get; set; }
        public int Population { get; set; }

        public Country()
        {
            this.CountryCode = Helpers.IdGenerator.CreateId();
        }
    }
}
