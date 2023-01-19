namespace OOPExampleSales.Entities.Time
{
    class Time
    {
        public int TimeCode { get; }
        public int Day { get; set; }
        public int Qty { get; set; }
        public int Working { get; set; }
        public int DayNumber { get; set; }

        public Time()
        {
            this.TimeCode = Helpers.IdGenerator.CreateId();
        }
    }
}
