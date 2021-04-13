using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectTest
{
    public class Worker : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Выпуск продукции");
        }
    }
}
