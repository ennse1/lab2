using System;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //RomanNumberExcaption
               // RomanNumber r1 = new RomanNumber(0);
                RomanNumber r2 = new RomanNumber(25);
                RomanNumber r3 = new RomanNumber(5);
                RomanNumber r4 = new RomanNumber(13);
                RomanNumber r5 = new RomanNumber(31);
                RomanNumber r6 = new RomanNumber(89);
                Console.WriteLine($"Сложение: {r2.ToString()} + {r6.ToString()} = {RomanNumber.Add(r2, r6).ToString()}");
                Console.WriteLine($"Деление: {r2.ToString()} / {r3.ToString()} = {RomanNumber.Div(r2, r3).ToString()}");
                Console.WriteLine($"Вычитание: {r6.ToString()} - {r5.ToString()} = {RomanNumber.Sub(r6, r5).ToString()}");
                Console.WriteLine($"Умножение: {r3.ToString()} * {r4.ToString()} = {RomanNumber.Mul(r3, r4).ToString()}");
                RomanNumber[] r = { r2, r3, r4, r5, r6 };
                Array.Sort(r);
                Console.WriteLine("Результат сортировки");
                foreach (var item in r)
                {
                    Console.WriteLine(item.ToString());
                }
                
            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            
        }
    }
}
