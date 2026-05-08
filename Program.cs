using System;

namespace SecureAdminSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Tizimga xush kelibsiz!");
            
            if (IsCorrectPassword())
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Siz tizimga admin sifatida kirdingiz.");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Keyinroq tizimga to'g'ri parol bilan kirishga harakat qilib ko'ring.");
            }
        }

        public static bool IsCorrectPassword()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Iltimos parolingizni kiriting: ");
                string password = Console.ReadLine();

                if (password == "admin123")
                {
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Noto'g'ri parol kiritdingiz.");
                    Console.ResetColor();
                    Console.WriteLine($"Qolgan urunishlaringiz soni {3-i} ta...");
                }
            }
            
            return false;
        }
    }
}