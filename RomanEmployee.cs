using System;

namespace Singleton
{
    public class RomanEmployee
    {
        private DateTime startWork;
        private static RomanEmployee instance;

        protected RomanEmployee() { }

        public static TimeSpan WorkingTime()
        {
            return IsWorking() ? DateTime.Now - instance.startWork : TimeSpan.FromSeconds(-1);
        }

        public static bool IsWorking()
        {
            return (instance != null);
        }

        public static RomanEmployee Start()
        {
            if (instance == null)
            {
                instance = new RomanEmployee();
                instance.startWork = DateTime.Now;
            }
            return instance;
        }
        public static void Stop()
        {
            instance = null;
        }
    }
}
