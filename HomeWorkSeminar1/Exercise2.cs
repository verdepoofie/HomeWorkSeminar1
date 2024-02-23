using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar1
{
    internal class Exercise2
    {
        private double pointsSumm = 0;
        private double average = 0;
        public Exercise2(double programmingPoints, double mathPoints, double physicsPoints)
        {
            pointsSumm = programmingPoints + mathPoints + physicsPoints;
            average = pointsSumm / 3;
        }
        public void Execute()
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Сумма баллов: " + pointsSumm.ToString());
            Console.WriteLine("Средний балл: " + average.ToString());
        }
    }
}
