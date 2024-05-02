using System;
using System.Linq;

public static class Calculator
{
    public static int SumNumbers(string numbers, char delimiter = ',')
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        var numberArray = numbers.Split(delimiter)
                                 .Select(n =>
                                 {
                                     if (!int.TryParse(n, out var parsed))
                                         throw new ArgumentException("Введены неверные данные!");
                                     // Если число отрицательное, возвращаем 0
                                     return parsed < 0 ? 0 : parsed;
                                 })
                                 .Where(n => n <= 10)
                                 .Take(5)
                                 .ToList();

        return numberArray.Sum();
    }
}

namespace UnitTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // пустой метод Main (без него не дает запустить)
        }
    }
}
