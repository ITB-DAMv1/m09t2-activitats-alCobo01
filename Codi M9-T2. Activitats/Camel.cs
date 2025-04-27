namespace Codi_M9_T2._Activitats
{
    public class Camel
    {
        private static readonly Random random = new Random();


        public int Id { get; set; }
        public int SleepTime { get; set; }

        public Camel(int id)
        {
            Id = id;

            int minSleep = random.Next(1, 50);
            int maxSleep = random.Next(minSleep + 1, 101);
            SleepTime = random.Next(minSleep, maxSleep);

        }
    }
}
