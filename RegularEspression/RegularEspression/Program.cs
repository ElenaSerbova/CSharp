using System;
using System.Text.RegularExpressions;

namespace RegularEspression
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Elena Sidorova  lena11111@gmail.com manager";
            string pattern = @"\w+@\w+\.\w{2,}";

            Regex regex = new Regex(pattern);

            Console.WriteLine(regex.IsMatch(text));

            Match match = regex.Match(text);
            Console.WriteLine(match.Value);

            string result = regex.Replace(text, "*********");
            Console.WriteLine(result);

            PhoneTest();
        }

        static void PhoneTest()
        {
            string phone;

            Console.Write("Enter the phone(8(___)___-__-__): ");
            phone = Console.ReadLine();

            string pattern = @"^\d\(\d{3}\)\d{3}-\d{2}-\d{2}$";

            if (Regex.IsMatch(phone, pattern))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
