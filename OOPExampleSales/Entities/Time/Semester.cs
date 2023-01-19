namespace OOPExampleSales.Entities.Time
{
    class Semester
    {
        public int SemesterCode { get; }
        public string Description { get; set; }

        public Semester()
        {
            this.SemesterCode = Helpers.IdGenerator.CreateId();
        }
    }
}
