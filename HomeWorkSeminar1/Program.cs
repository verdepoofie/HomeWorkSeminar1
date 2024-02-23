using System.Text;

namespace HomeWorkSeminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Exercise1 exercise1 = new Exercise1();
            Exercise2 exercise2 = new Exercise2(exercise1.ProgrammingPoints, exercise1.MathPoints, exercise1.PhysicsPoints);
            Console.WriteLine("Выберете задание (Введие 1 или 2)");
            var answer = Console.ReadKey();
            Console.WriteLine();
            if(answer.Key == ConsoleKey.D1)
                exercise1.Execute();
            else if(answer.Key == ConsoleKey.D2)
                exercise2.Execute();
            Console.ReadLine();
        }
    }
}
