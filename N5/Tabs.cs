using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    internal class Tabs
    {
        /// <summary>
        /// Заглушка первого уровня возвращает 1 если значение числа больше 0
        /// </summary>
        /// <param name="x">Значение</param>
        /// <returns>Результат выполнения функции</returns>
        public double findSolutionDown(double x)
        {
            double lvl1 = (log(5, x, 3) * log(10, x)) + log(3, x);//1 часть уравнения
            double lvl2 = lvl1 / ln(x);//1 и 2 часть уравнения
            double lvl3 = lvl2 + (ln(x) * log(5, x));//1,2 и 3 часть уравнения

            return lvl3;//результат уравнения
        }
        /// <summary>
        /// Заглушка первого уровня возвращает 1 если значение числа меньше или равно 0
        /// </summary>
        /// <param name="x">Значение</param>
        /// <returns>Результат выполнения функции</returns>
        public double findSolutionUp(double x)
        {
            double lvl1 = ((cot(x) / sec(x)) - tan(x)) * sin(x);//1 часть уравнения
            double lvl2 = lvl1 / cos(x);//1 и 2 часть уравнения
            double lvl3 = lvl2 * Math.Pow((sin(x) + cos(x)) + cos(x), 2);//1,2 и 3 часть уравнения

            return lvl3;//результат уравнения
        }
        /// <summary>
        /// Заглушка для 5 уровня возвращает синус значения
        /// </summary>
        /// <param name="num">Значение</param>
        /// <returns>Синус передаваемого значения</returns>
        public double sin(double num)
        {
            return Math.Sin(num);//возвращает синус числа
        }
        /// <summary>
        /// Заглушка 4 уровня возвращает косинус
        /// </summary>
        /// <param name="num">Значение</param>
        /// <returns>Косинус получаемого значения</returns>
        public double cos(double num)
        {
            return Math.Sqrt(1 - Math.Pow(sin(num), 2));//возвращает косинус по формуле основного тригонометрического тождества
        }
        /// <summary>
        /// Заглушка 3 уровня возвращает значение секанса
        /// </summary>
        /// <param name="num">Значение</param>
        /// <returns>Секанс передаваемогго значения</returns>
        public double sec(double num)
        {
            return 1 / cos(num);//возвращае секанс по формуле
        }
        /// <summary>
        /// Заглушка 3 уровня возвращает значение тангенса
        /// </summary>
        /// <param name="num">Значение</param>
        /// <returns>Тангенс полученого значения</returns>
        public double tan(double num)
        {
            return sin(num) / cos(num);//возврвщвет тангенс угла
        }
        /// <summary>
        /// Заглушка 3 уровня возвращает значение котангенса
        /// </summary>
        /// <param name="num">Значение</param>
        /// <returns>Котангенс полученого значения</returns>
        public double cot(double num)
        {
            return cos(num) / sin(num);//возвращает котангенс угла
        }
        /// <summary>
        /// Заглушка для 5 уровня возвращает значение натурального логарифма
        /// </summary>
        /// <param name="num">Значение</param>
        /// <returns>Значение логарифма с передаваемым значением</returns>
        public double ln(double num)
        {
            return Math.Log(num);//возвращает значение натурального логарифма
        }
        /// <summary>
        /// Заглушка 3 уровня возвращает значение логарифма
        /// </summary>
        /// <param name="baseNum">Основание</param>
        /// <param name="num">Значение</param>
        /// <returns>Значение логарифма</returns>
        public double log(double baseNum, double num)
        {
            return ln(num) / ln(baseNum);//Возвращает значение логарифма по свойствам натурального логарифма
        }
        /// <summary>
        /// Заглушка 3 уровня возвращает значение логарифма в степени
        /// </summary>
        /// <param name="baseNum">Основание</param>
        /// <param name="num">Значение</param>
        /// <param name="degree">Степень</param>
        /// <returns>Значение логарифма</returns>
        public double log(double baseNum, double num, double degree)
        {
            return degree * log(baseNum, num);//Возвращает значение логарифма по основным свойствам логарифма
        }
    }
}
