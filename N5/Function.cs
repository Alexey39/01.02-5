using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    internal class Function
    {
        /// <summary>
        /// Возвращает результат системы функций при х больше 0
        /// </summary>
        /// <param name="x">Значение</param>
        /// <returns>Результат системы функций</returns>
        public double findSolutionDown(double x)
        {
            double lvl1 = (log(5, x, 3) * log(10, x)) + log(3, x);//1 часть уравнения
            double lvl2 = lvl1 / ln(x);//1 и 2 часть уравнения
            double lvl3 = lvl2 + (ln(x) * log(5, x));//1,2 и 3 часть уравнения

            return lvl3;//результат уравнения
        }
        /// <summary>
        /// Возвращает результат системы функций при х меньше или равной 0
        /// </summary>
        /// <param name="x">Значение</param>
        /// <returns>Результат системы функций</returns>
        public double findSolutionUp(double x)
        {
            double lvl1 = ((cot(x) / sec(x)) - tan(x)) * sin(x);//1 часть уравнения
            double lvl2 = lvl1 / cos(x);//1 и 2 часть уравнения
            double lvl3 = lvl2 * Math.Pow((sin(x) + cos(x)) + cos(x), 2);//1,2 и 3 часть уравнения

            return lvl3;//результат уравнения
        }
        /// <summary>
        /// Возвращает синус зная его число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Синус передаваемого  чила</returns>
        public double sin(double num)
        {
            return Math.Sin(num);//возвращает синус числа
        }
        /// <summary>
        /// Возвращает косинус зная его число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Косинус передаваемого числа</returns>
        public double cos(double num)
        {
            return Math.Sqrt(1 - Math.Pow(sin(num), 2));//возвращает косинус по формуле основного тригонометрического тождества
        }
        /// <summary>
        /// Возвращает секанс, число обратное косинусу, зная его число 
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Секанс передаваемого числа</returns>
        public double sec(double num)
        {
            return 1 / cos(num);//возвращае секанс по формуле
        }
        /// <summary>
        /// Возвращает тангенс зная его число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Тангенс передаваемого числа</returns>
        public double tan(double num)
        {
            return sin(num) / cos(num);//возврвщвет тангенс угла
        }
        /// <summary>
        /// Возвращает котангенс зная его число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Котангенс передаваемого числа</returns>
        public double cot(double num)
        {
            return cos(num) / sin(num);//возвращает котангенс угла
        }
        /// <summary>
        /// Возвращает значение натурального логарифма
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Значение логарифма</returns>
        public double ln(double num)
        {
            return Math.Log(num);//возвращает значение натурального логарифма
        }
        /// <summary>
        /// Возвращает значение логарифма числа Num с основанием baseNum
        /// </summary>
        /// <param name="baseNum">Число</param>
        /// <param name="num">Основание</param>
        /// <returns>Значение логарифма</returns>
        public double log(double baseNum, double num)
        {
            return ln(num) / ln(baseNum);//Возвращает значение логарифма по свойствам натурального логарифма
        }
        /// <summary>
        /// Возвращает значение логарифма числа Num с основанием baseNum в степени Degree
        /// </summary>
        /// <param name="baseNum">Основание</param>
        /// <param name="num">Число</param>
        /// <param name="degree">Степень</param>
        /// <returns></returns>
        public double log(double baseNum, double num, double degree)
        {
            return degree * log(baseNum, num);//Возвращает значение логарифма по основным свойствам логарифма
        }
    }
}
