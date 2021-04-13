using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectTest
{
    public class Manager : Employee
    {
        public void TakeTask() 
        {
            Console.WriteLine("Выдаю задание");
        }

        public override void Work()
        {
            Console.WriteLine("сбор заказов");
        }
    }
}
