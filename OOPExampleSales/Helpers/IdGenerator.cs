namespace OOPExampleSales.Helpers
{
    static class IdGenerator
    {
        private static Random _rnd = new Random();

        public static int CreateId()
        {
            return _rnd.Next();
        }
    }
}
