using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    internal class Drivers
    {
        public double findSolutionDown(double x)//драйвер 2 уровня
        {
            double lvl1 = (log(5, x, 3) * log(10, x)) + log(3, x);//1 часть уравнения
            double lvl2 = lvl1 / ln(x);//1 и 2 часть уравнения
            double lvl3 = lvl2 + (ln(x) * log(5, x));//1,2 и 3 часть уравнения

            return lvl3;//результат уравнения
        }
        public double findSolutionUp(double x)//драйвер 2 уровня
        {
            double lvl1 = ((cot(x) / sec(x)) - tan(x)) * sin(x);//1 часть уравнения
            double lvl2 = lvl1 / cos(x);//1 и 2 часть уравнения
            double lvl3 = lvl2 * Math.Pow((sin(x) + cos(x)) + cos(x), 2);//1,2 и 3 часть уравнения

            return lvl3;//результат уравнения
        }
        public double sec(double num)//драйвер 3 уровня
        {
            return 1 / cos(num);//возвращае секанс по формуле
        }
        public double cos(double num)//драйвер 4 уровня
        {
            return Math.Sqrt(1 - Math.Pow(sin(num), 2));//возвращает косинус по формуле основного тригонометрического тождества
        }
        public double sin(double num)//5 уровень
        {
            return Math.Sin(num);//возвращает синус числа
        }

        public double log(double baseNum, double num)//драйвер 3 уровня
        {
            return ln(num) / ln(baseNum);//Возвращает значение логарифма по свойствам натурального логарифма
        }
        public double ln(double num)//драйвер 5 уровня
        {
            return Math.Log(num);//возвращает значение натурального логарифма
        }
        public double tan(double num)//драйвер 3 уровня
        {
            return sin(num) / cos(num);//возврвщвет тангенс угла
        }
        public double cot(double num)//драйвер 3 уровня
        {
            return cos(num) / sin(num);//возвращает котангенс угла
        }
        public double log(double baseNum, double num, double degree)//драйвер 3 уровня
        {
            return degree * log(baseNum, num);//Возвращает значение логарифма по основным свойствам логарифма
        }
    }
}
