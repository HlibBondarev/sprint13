namespace ViewTask.Services
{
    public class SimpleTimeService : ITimeService
    {
        public DateTime GetTimeForTomorrow()
        {
            return DateTime.Now;
        }

        public string GetTime()
        {
            return System.DateTime.Now.ToString("dd:HH:mm:ss");
        }
    }
}
