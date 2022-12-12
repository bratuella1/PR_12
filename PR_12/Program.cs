//*************************
// практическая работа №12*
// выполнил: Ханов Артур  *
//*************************
using System;

namespace PR_12
{
    internal class Program
    {
        static string Stroka(string s, char a, char b, char c)
        {
            string pod = a.ToString() + b.ToString() + c.ToString();//складываем буквы в строку
            string zamena = "xyz".ToUpper();//заменяем на заглавные буквы XYZ
            string new_s = s.Replace(pod, zamena);//заменяем abc на XYZ
            return new_s; // возвращаем результат
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку");
                string s = Console.ReadLine();//вводим строку с клавиатуры
                Console.WriteLine("Введите 3 буквы:");
                char a = char.Parse(Console.ReadLine());//вводим первую букву
                char b = char.Parse(Console.ReadLine());//вводим вторую букву
                char c = char.Parse(Console.ReadLine());//вводим третью букву
                Console.WriteLine(Stroka(s, a, b, c));//вызываем метод и выводим результат на экран
            }
            catch (Exception e)//обработка исключения
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
