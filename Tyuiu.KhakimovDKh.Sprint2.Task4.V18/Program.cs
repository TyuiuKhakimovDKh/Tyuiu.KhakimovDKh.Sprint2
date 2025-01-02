using Tyuiu.KhakimovDKh.Sprint2.Task4.V18.Lib;
namespace Tyuiu.KhakimovDKh.Sprint2.Task4.V18
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 Выполнил: Хакимов Д.Х. ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович  ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УCЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на с#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаоквых массивов по длине.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
