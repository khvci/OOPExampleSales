namespace OOPExampleSales.Entities.Time
{
    class Year
    {
        public int YearCode { get; }
        public string Description { get; set; }

        public Year()
        {
            this.YearCode = Helpers.IdGenerator.CreateId();
        }
    }
}
