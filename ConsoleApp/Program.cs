using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
namespace ConsoleApp
{
    internal class Program
    {
        /* 1. User modeli yaradın, Id, Name, Surname və Age propertyləri olsun.Daha sonra başqa class daxilində
        parameter olaraq List qəbul edən və geriyə userlərə aid unikal yaşların siyahısını qaytaran metod yazın
        və metodu main metodu daxilində çağırıb nəticəni ekrana yazdırın.*/
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            bool w = true;
            int id = 1;
            while (w)
            {
                Console.WriteLine("enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("enter Surname");
                string sname = Console.ReadLine();
                Console.WriteLine("enter age:");
                int age;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.WriteLine("Invalid age. Please enter a valid number.");
                    }
                    else
                    {
                        break;
                    }
                    w = false;

                }
                User newUser = new User
                {
                    Id = id,
                    Name = name,
                    Surname = sname,
                    Age = age,
                };
                users.Add(newUser);
                id++;

                bool t = true;
                while (t)
                {
                    Console.WriteLine("Do you want to leave? (yes / no)");
                    string leave = Console.ReadLine().ToLower();
                    if (leave == "yes")
                    {
                        Console.WriteLine("Stop");
                        w = false;
                        break;
                    }
                    else if (leave == "no")
                    {
                        Console.WriteLine("We are continue ");
                        t = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                    }
                }

            }
            UserCall userManager = new UserCall();

            List<int> uniqueAges = userManager.UniqueAges(users);

            Console.WriteLine("Unique ages:");
            foreach (int a in uniqueAges)
            {
                Console.WriteLine(a);
            }
        }
    }
}