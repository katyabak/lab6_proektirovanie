using System;
using System.Linq;

public static class Calculator
{
    public static int SumNumbers(string numbers, char delimiter = ',')
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        var numberArray = numbers.Split(delimiter)
                                 .Select(n => int.TryParse(n, out var parsed) ? parsed : 0) // ïðåîáðàçóåì â ÷èñëà, èãíîðèðóÿ íå ÷èñëîâûå çíà÷åíèÿ
                                 .Where(n => n >= 0 && n <= 10)
                                 .Take(5);

        // ïðîâåðêà, åñòü ëè â ñåðèè ÷èñåë îòðèö. ÷èñëî
        if (numberArray.Any(n => n < 0))
            return 0;

        return numberArray.Sum();
    }

}

namespace UnitTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ïóñòîé ìåòîä Main (áåç íåãî íå äàåò çàïóñòèòü)
        }
    }
}
