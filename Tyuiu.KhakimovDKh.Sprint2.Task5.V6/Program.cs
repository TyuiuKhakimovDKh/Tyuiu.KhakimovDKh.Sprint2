using Tyuiu.KhakimovDKh.Sprint2.Task5.V6.Lib;
namespace Tyuiu.KhakimovDKh.Sprint2.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил:Хакимов Д.Х | ИИПб-24-2";
            Console.WriteLine("*********************************************************************** ***");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович  | ИИПб-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая определяет полное название соответствующей  *");
            Console.WriteLine("* карты по заданным номеру масти и номеру достоинства карты.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите номер масти:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите номер достоинства карты:");
            int k = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindCardNameAndValue(m, k);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
