using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class RomanEmployee
    {
        private static RomanEmployee instance;
        protected RomanEmployee() { }
        public static RomanEmployee Instance()
        {
            if(instance==null)
            {
                instance = new RomanEmployee();
            }
            return instance;
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
            return instance;
        }

        public static void Stop()
        {
            instance = null;
        }
    }
}
