using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csnei1
{
    internal class Program
    {
        static void Example03()
        {
            Console.Write("Birthday: ");
            string stryear = Console.ReadLine();
            int year = 0;

            year = Convert.ToInt32(stryear);

            year = Int32.Parse(stryear);

            bool result = Int32.TryParse(stryear, out year);
            if (result == false)
            {
                Console.WriteLine("No correct");
            }
        }

        /*static void Example04(int x)
        {
            x = x + 1;
        }

        static void Example05(User user)
        {
            user.Age = user.Age + 1;
        }*/

        static void task1()
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string scdname = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Приветсвую вас "+name+" "+scdname+" "+fname);
        }

        static void task2()
        {
            int sum = 0;
            Console.WriteLine("Вводите числа: ");
            string a = "";
            while(true)
            {
                a = Console.ReadLine();
                if (a == "result")
                    break;

                int digit = Convert.ToInt32(a);
                sum += digit;
            }


            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            task1();
            task2();

            Console.ReadKey();
        }
    }

    /*public class User
    {
        public int Age { get; set; }
    }*/
}
