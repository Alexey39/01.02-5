using System;
using System.Diagnostics;

namespace N5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function myFun = new Function();//экземпляр класса содержащий функции
            Tabs myTabs = new Tabs();//экземпляр класса содержащий заглушки
            Drivers myDrivers = new Drivers();//экземпляр класса содержащий драйвера

            for (int x = -5; x < 6; x ++)//цикл с изменением значения числа x для проверки работы
            {
                double result;
                if(x <= 0)
                {
                    result = myDrivers.findSolutionUp(x);//результат решения системы функций с заданным х
                }
                else
                {
                    result = myDrivers.findSolutionDown(x);//результат решения системы функций с заданным х
                }
                Debug.WriteLine("Результат решения системы функций с  х = {0} равен {1}", x, result);
            }

        }
    }
}