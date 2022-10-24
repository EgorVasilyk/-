using System;
using System.ComponentModel.Design;

namespace ежедневник
{
    internal class Program
    {
        static void fst()
        {
            Console.Clear();
            Console.WriteLine("Дата: 24.10");
            Console.WriteLine("Нет заметок");
            ConsoleKeyInfo arrow = Console.ReadKey();
           
            if (arrow.Key == ConsoleKey.RightArrow)
            {
                scd();
            }
           
        }

        static void scd()
        {
            Console.Clear();
            Console.WriteLine("Дата: 25.10");
            Console.WriteLine("Заметок: 1 - практическая");
            ConsoleKeyInfo arrow = Console.ReadKey();
            if (arrow.Key == ConsoleKey.LeftArrow)
            {
                fst();
            }
            if (arrow.Key == ConsoleKey.RightArrow)
            {
                thd();
            }
            if (arrow.Key == ConsoleKey.Enter)
            {
                note();
            }
        }

        static void thd()
        {
            Console.Clear();
            Console.WriteLine("Дата: 26.10");
            Console.WriteLine("Нет заметок");
            ConsoleKeyInfo arrow = Console.ReadKey();
            if (arrow.Key == ConsoleKey.LeftArrow)
            {
                scd();
            }
            if (arrow.Key == ConsoleKey.RightArrow)
            {
                frh();
            }
           
        }

        static void frh()
        {
            Console.Clear();
            Console.WriteLine("Дата: 27.10");
            Console.WriteLine("Нет заметок");
            ConsoleKeyInfo arrow = Console.ReadKey();
            if (arrow.Key == ConsoleKey.LeftArrow)
            {
                thd();
            }
            if (arrow.Key == ConsoleKey.RightArrow)
            {
                fih();
            }
            
        }

        static void fih()
        {
            Console.Clear();
            Console.WriteLine("Дата: 28.10");
            Console.WriteLine("Нет заметок");
            ConsoleKeyInfo arrow = Console.ReadKey();
            if (arrow.Key == ConsoleKey.LeftArrow)
            {
                frh();
            }
            
        }

        static void note()
        {
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Заметка:");
            Console.WriteLine("Срок сдачи практической.");
            Console.WriteLine("Срок выполнения: 19:00");
            ConsoleKeyInfo arrow = Console.ReadKey();
            if (arrow.Key == ConsoleKey.Escape)
            {
                scd();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Используйте ← и → для переключения между датами");
            Console.WriteLine("Нажмите enter для просмотра заметки и esc для выхода из заметки");
            Console.WriteLine("Введите интересующую вас дату: ");
            string a = Console.ReadLine();
            float b = Convert.ToInt32(a);

            if (b == 24)
            {
                fst();
            }
            if (b == 25)
            {
                scd();
            }
            if (b == 26)
            {
                thd();
            }
            if (b == 27)
            {
                frh();
            }
            if (b == 28)
            {
                fih();
            }
        }
    }
}