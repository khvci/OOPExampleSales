namespace OOPExampleSales.Entities.Time
{
    class Quarter
    {
        public int QuarterCode { get; }
        public string Description { get; set; }

        public Quarter()
        {
            this.QuarterCode = Helpers.IdGenerator.CreateId();
        }
    }
}
