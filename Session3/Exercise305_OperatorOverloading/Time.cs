namespace Exercise305_OperatorOverloading
{
    public class Time
    {
        public int Hours;
        public int Minutes;


        public static Time operator +(Time time1, Time time2)
        {
            return new Time
            {
                Hours = time1.Hours + time2.Hours,
                Minutes = time1.Minutes + time2.Minutes
            };

        }

        public static Time operator +(Time time, int minutes)
        {
            return new Time()
            {
                Hours = time.Hours,
                Minutes = time.Minutes + minutes
            };
        }


        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}.";
        }
    }
}