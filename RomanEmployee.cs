using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class RomanEmployee
    {
        private static DateTime startWork;
        private static DateTime endWork;
        private static Boolean workOn;
        private static int noWork;
        private static TimeSpan workTime;
        private static RomanEmployee instance;

        protected RomanEmployee() { }

        public static RomanEmployee Instance()
        {
            if (instance == null)
            {
                instance = new RomanEmployee();
            }
            return instance;
        }

        public static TimeSpan WorkingTime()
        {
            if (workOn == true)
            {
                workTime = endWork - startWork;
                return workTime;
            }
            else
                noWork = -1;
            TimeSpan noWorkToSpan = TimeSpan.FromSeconds(noWork);
            return noWorkToSpan;
        }

        public static bool IsWorking()
        {
            if (instance != null)
                return true;
            else
                return false;
        }

        public static RomanEmployee Start()
        {
            RomanEmployee.Instance();
            startWork = DateTime.Now;
            workOn = true;
            return instance;
        }

        public static void Stop()
        {
            instance = null;
            endWork = DateTime.Now;
              
        }
    }
}
