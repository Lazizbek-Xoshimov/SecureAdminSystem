using System;

namespace SecureAdminSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Tizimga xush kelibsiz!");
            Console.Write("Tizimga kirish parolingizni kiriting: ");
            string password = ChangePasswordAppearance();
            
            if (IsCorrectPassword(password))
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Siz tizimga admin sifatida kirdingiz.");
                Console.ResetColor();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Keyinroq tizimga to'g'ri parol bilan kirishga harakat qilib ko'ring.");
            }
        }

        public static bool IsCorrectPassword(string password)
        {
            for (int i = 1; i <= 2; i++)
            {
                if (password == "admin123")
                {
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Noto'g'ri parol kiritdingiz.");
                    Console.ResetColor();
                    Console.WriteLine($"Qolgan urunishlaringiz soni {3-i} ta...");

                    Console.Write("Iltimos parolingizni qayta kiriting: ");
                    password = ChangePasswordAppearance();
                }
            }
            
            return false;
        }

        public static string ChangePasswordAppearance()
        {
            string password = string.Empty;
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                    continue;

                password += key.KeyChar;
                Console.Write("*");

            }while (key.Key != ConsoleKey.Enter);

            return password;
        }
    }
}