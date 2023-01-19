namespace OOPExampleSales.Entities.Product
{
    class Department
    {
        public int DepartmentCode { get; }
        public string Name { get; set; }

        public Department()
        {
            this.DepartmentCode = Helpers.IdGenerator.CreateId();
        }
    }
}
