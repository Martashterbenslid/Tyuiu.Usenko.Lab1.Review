using UsenkoLib;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            Console.Title = "Спринт #1 | Выполнила: Ющенко В.Е | МКМб-22-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Лабраторная работа #1                                                      *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #13                                                                *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("X: = 1");
            Console.WriteLine("Y: = 2");
            Console.WriteLine("A: = 3");
            Console.WriteLine("X2: = 3");
            Console.WriteLine("Y2: = 2");
            Console.WriteLine("A2: = 1");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("-----------------------");
            int x = 1; int y = 2; int a = 3;
            Console.WriteLine("* Первая функция:                                                            *");
            double zf1 = z1.Zfunc1(x, y, a);
            Console.WriteLine($"z = {zf1}");
            int x2 = 3; int y2 = 2; int a2 = 1;
            Console.WriteLine("* Вторая функция:                                                            *");
            double zf2 = z2.Zfunc2(x2, y2, a2);
            Console.WriteLine($"z = {zf2}");
        }
    }
}