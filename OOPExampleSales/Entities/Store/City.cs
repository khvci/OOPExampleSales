namespace OOPExampleSales.Entities.Store
{
    class City
    {
        public int CityCode { get; }
        public string Name { get; set; }
        public int Population { get; set; }

        public City()
        {
            this.CityCode = Helpers.IdGenerator.CreateId();
        }
    }
}
