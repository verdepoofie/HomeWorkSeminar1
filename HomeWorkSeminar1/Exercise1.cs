using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar1
{
    internal class Exercise1
    {
        private string fullName = "Иванов Иван Иванович";
        private int age = 30;
        private string email = "IvanIvanov@mail.com";
        private double programmingPoints = 70.5;
        public double ProgrammingPoints => programmingPoints;
        private double mathPoints = 85;
        public double MathPoints => mathPoints;
        private double physicsPoints = 66;
        public double PhysicsPoints => physicsPoints;
        public void Execute()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Ф.И.О: " + fullName);
            Console.WriteLine("Возраст: " + age.ToString());
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Баллы по программированию: " + programmingPoints.ToString());
            Console.WriteLine("Баллы по математике: " +  mathPoints.ToString());
            Console.WriteLine("Баллы по физике: " +  physicsPoints.ToString());
        }

    }
}
