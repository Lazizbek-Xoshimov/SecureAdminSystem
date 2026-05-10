using System;

namespace SecureAdminSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Tizimga xush kelibsiz!");

            bool infinity = true;

            while(infinity)
            {
                Console.Write("Tizimga kirish parolingizni kiriting: ");
                string password = ChangePasswordAppearance();
                
                if (IsCorrectPassword(password))
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Siz tizimga admin sifatida kirdingiz.");
                    Console.ResetColor();

                    Console.WriteLine("1. Foydalanuvchilar ro'yxati");
                    Console.WriteLine("2. Sozlamalar");
                    Console.WriteLine("3. Hisobotlar");
                    Console.WriteLine("4. Chiqish");

                    Console.Write("Kerakli bo'limni tanlang: ");
                    int optionAdmin = int.Parse(Console.ReadLine());

                    switch (optionAdmin)
                    {
                        case 1:
                            {
                                break;
                            }
                        case 2:
                            {
                                break;
                            }
                        case 3:
                            {
                                break;
                            }
                        case 4:
                            {
                                infinity = false;
                                break;
                            }
                    }
                }
                else
                {
                    Console.Clear();
                    CountingTime();
                }
            } 
        }

        public static bool IsCorrectPassword(string password)
        {
            int countInputPassword = 2;
            
            while(countInputPassword > 0 && password != "admin123")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Noto'g'ri parol kiritdingiz.");
                Console.ResetColor();
                Console.WriteLine($"{countInputPassword} ta urunishlaringiz qoldi.");
                Console.Write("Iltimos parolingizni qayta kiriting: ");
                password = ChangePasswordAppearance();

                countInputPassword --;
            }
            
            return password == "admin123" ? true : false;
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
                else if (key.Key == ConsoleKey.Backspace && password != string.Empty)
                {
                    password = password.Remove(password.Length-1);
                    Console.SetCursorPosition(38 + password.Length, 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(38 + password.Length, 1);
                }
                else
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            }while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();

            return password;
        }

        public static void CountingTime()
        {
            DateTime lockTime = DateTime.Now.AddSeconds(10);
            int countdown = 10;

            while (DateTime.Now < lockTime)
            {
                int remaining = lockTime.Second - DateTime.Now.Second;

                if (countdown == remaining)
                {
                    Console.Clear();
                    Console.WriteLine($"{remaining} sekunddan so'ng qayta uruning...");
                    countdown --;
                }
            }

            Console.Clear();
        }
    }
}