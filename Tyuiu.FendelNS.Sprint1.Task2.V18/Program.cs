using Tyuiu.FendelNS.Sprint1.Task2.V18.Lib;
namespace Tyuiu.FendelNS.Sprint1.Task2.V18
{
    class program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Фендель.Н.С | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арефметические операторы в С#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Фендель Николай Сергеевич|  СМАРТБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователяисходные данные,  *");
            Console.WriteLine("* выполняет указанные рассчёты и печатает на экране.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            int z;

            Console.WriteLine("Введите значение Z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь боковой поверхности параллелепипеда X, Y, Z = " + ds.CalculateSideSquareParallelepiped(x, y, z));

            Console.ReadLine();
        }








    }
}