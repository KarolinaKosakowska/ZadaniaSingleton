using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roman rozpoczyna pracę");
            var roman = RomanEmployee.Start();
            Console.WriteLine($"Pracownik jest w pracy: {RomanEmployee.IsWorking()}");
            Console.WriteLine("Roman kończy pracę");
            RomanEmployee.Stop();
            Console.WriteLine($"Pracownik jest w pracy: {RomanEmployee.IsWorking()}");
            Console.ReadKey();
        }
    }
    
}
