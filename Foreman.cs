using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectTest
{
    public class Foreman : Employee
    {
        public void CheckWorker()
        {
            Console.WriteLine("Проверка рабочих");
        }

        public override void Work()
        {
            Console.WriteLine("Закупка материалов");
        }
    }
}
