using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Roman rozpoczyna pracę");
            //RomanEmployee.Start();
            //Console.WriteLine($"Pracownik jest w pracy: {RomanEmployee.IsWorking()}");
            //Console.WriteLine("Roman kończy pracę");
            //RomanEmployee.Stop();
            //Console.WriteLine($"Pracownik jest w pracy: {RomanEmployee.IsWorking()}");
            //Console.ReadKey();

            //Bonus
            Console.WriteLine("Roman nie pracuje");
            Console.WriteLine($"Pracownik pracuje już {RomanEmployee.WorkingTime()}");
            Console.WriteLine("Roman pracuje");
            RomanEmployee.Start();
            Thread.Sleep(3000);
            Console.WriteLine($"Pracownik pracuje już {RomanEmployee.WorkingTime()}");
            Console.Read();
        }
    }    
}
