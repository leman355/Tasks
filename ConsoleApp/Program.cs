using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;
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
        /* static void Main(string[] args)
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
        */



        /*2. Metod yazın, metod istənilən sayda int qəbul edə bilər və qəbul etdiyi ədədlərin cəmini
             return edəcək. Metodu çağırın və nəticəni ekrana yazdırın. */
        /*static int Params(params int[] args)
        {
            int sum = 0;
            foreach (int i in args)
            {
                sum += i;
            }
            Console.WriteLine("Result: " + sum);
            return sum;

        }

        static void Main()
        {
            List<int> numbers = new List<int>();
            bool w = true;
            while (w)
            {
            Console.WriteLine("Enter inumber. If you want to exit write 'exit'");
                string value = Console.ReadLine();
                if (value.ToLower() == "exit")
                {
                    break;
                }
                if (int.TryParse(value, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a valid number.");
                }
            }
            Params(numbers.ToArray());
        }*/

        /*3. LinkedList yaradın və 10 dəyər əlavə edin.Daha sonra Console readline ilə int 
             dəyər əldə edin və linkedlist daxilində bu ədəddən sonrakı ədədi ekrana yazdırın.*/
        /* static void Main()
         {
             LinkedList<int> linkedList = new LinkedList<int>();
             Console.WriteLine("Enter 10 numbers");
             int num;
             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine($"Enter {i + 1} number");

                 string val = Console.ReadLine();
                 if (int.TryParse(val, out num))
                 {
                     linkedList.AddLast(num);
                 }
                 else
                 {
                     Console.WriteLine("Invalid number. Please enter a valid number.");
                     i--;
                 }
             }
             Console.WriteLine("Enter any number");
             int n = int.Parse(Console.ReadLine());
             LinkedListNode<int> node = linkedList.Find(n);

             if (node != null)
             {
                 LinkedListNode<int> nextNode = node.Next;

                 if (nextNode != null)
                 {
                     Console.WriteLine("Numbers after " + n + ":");
                     while (nextNode != null)
                     {
                         Console.Write(nextNode.Value + " ");
                         nextNode = nextNode.Next;
                     }
                 }
                 else
                 {
                     Console.WriteLine("There are no numbers after " + n);
                 }
             }
             else
             {
                 Console.WriteLine("The entered number was not found in the list.");
             }
         }*/



        //4. OOP principlərinə aid real nümunələr implement edin.

        /*static void Main()
        {
            Console.WriteLine("Enter account holder name: ");
            string name = Console.ReadLine();
            string accnum;
            do
            {
                Console.WriteLine("Enter account number (16 characters): ");
                accnum = Console.ReadLine();
            } while (accnum.Length != 16 || string.IsNullOrWhiteSpace(accnum));

            decimal balance;
            do
            {
                Console.WriteLine("Enter balance: ");
                if (!decimal.TryParse(Console.ReadLine(), out balance) || balance <= 0)
                {
                    Console.WriteLine("Invalid balance. Please enter a valid balance.");
                }
                else
                {
                    break;
                }
            } while (true);

            decimal intrate;
            do
            {
                Console.WriteLine("Enter interest rate: ");
                if (!decimal.TryParse(Console.ReadLine(), out intrate) || intrate <= 0)
                {
                    Console.WriteLine("Invalid interest rate. Please enter a valid interest rate.");
                }
                else
                {
                    break;
                }
            } while (true);
            SavingsAccount account = new SavingsAccount(name, accnum, balance, intrate);
            decimal interestAmount = account.CalculateInterest();
            Console.WriteLine($"Interest Amount: ${interestAmount}");
        }*/

        
        /*5. Dictionary yaradın, key-i GUİD və value-su List obyekti olsun (Id, name, surname, age). Daha sonra dictionary-ə 
             10 element əlavə edin və sonda dictionary-də yaşları eyni olan userləri eyni strukturlu başqa bir dictionary-ə
             yığın, dictionary-nin key-i yaş, value-su isə həmən yaşdakı userlər olacaq.*/
    
        /*static void Main()
        {
            Dictionary<Guid, User> userDict = new Dictionary<Guid, User>();
            bool w = true;
            int id = 1;

            while (w)
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Surname:");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter age:");

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
                }

                User newUser = new User
                {
                    Id = id,
                    Name = name,
                    Surname = sname,
                    Age = age,
                };

                Guid userGuid = Guid.NewGuid();
                userDict[userGuid] = newUser;
                id++;

                bool t = true;
                while (t)
                {
                    Console.WriteLine("Do you want to leave? (yes / no)");
                    string leave = Console.ReadLine().ToLower();
                    if (leave == "yes")
                    {
                        Console.WriteLine("Stopping...");
                        w = false;
                        break;
                    }
                    else if (leave == "no")
                    {
                        Console.WriteLine("Continuing...");
                        t = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                    }
                }
            }

             Dictionary<int, List<User>> usersByAge = userDict.Values.GroupBy(u => u.Age)
                .Where(g => g.Count() > 1)
                .ToDictionary(g => g.Key, g => g.ToList());

            foreach (var ageGroup in usersByAge)
            {
                Console.WriteLine($"Users with age {ageGroup.Key}:");
                foreach (var user in ageGroup.Value)
                {
                    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Surname: {user.Surname}");
                }
                Console.WriteLine();
            }
        }*/

        /*6. 2 ölçülü array yaradın, sətir və sütun sayını console readline ilə əldə edin.daha sonra array elementlərinə
             0-10 arası random ədədlər verin və arrayın baş və köməkçi dioqanal elementləri cəminin hasilini tapın.*/

        static void Main(string[] args)
        {
            int column;
            while (true)
            {
                Console.Write("Enter the number of columns: ");
                if (!int.TryParse(Console.ReadLine(), out column))
                {
                    Console.WriteLine("Invalid number. Please enter a valid number.");
                }
                else
                {
                    break;
                }
            }

            int row;
            while (true)
            {
                Console.Write("Enter the number of rows: ");
                if (!int.TryParse(Console.ReadLine(), out row))
                {
                    Console.WriteLine("Invalid number. Please enter a valid number.");
                }
                else
                {
                    break;
                }
            }

            int[,] matrix = new int[column, row];
            Random rnd = new Random();

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[i, j] = rnd.Next(0, 11);
                }
            }

            Console.WriteLine("Matrix:");
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int main = 1;
            int minor = 1;

            for (int i = 0; i < column; i++)
            {
                main *= matrix[i, i];
                minor *= matrix[i, row - 1 - i];
            }
            Console.WriteLine("\nMultiplying elements by main diagonal: " + main);
            Console.WriteLine("Multiplying elements by minor diagonal: " + minor);
        }
    }
}
