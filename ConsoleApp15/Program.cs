using System;

namespace predlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пожалуйста");
            string name = string.Format(Console.ReadLine());
            Console.WriteLine("Введите фамилию пожалуйста");
            string surname = string.Format(Console.ReadLine());
            Console.WriteLine("Введите год вашего рождения пожалуйста");
            string datebirthday = string.Format(Console.ReadLine());
            Console.WriteLine("Введите домен пожалуйста");
            string domen = string.Format(Console.ReadLine());
            Console.WriteLine("Введите домен пожалуйста");

            string Csurname = Converter.ConvertToLatin(surname);
            string Cname = Converter.ConvertToLatin(name);
            string date = datebirthday.Substring(2);

            Console.WriteLine("Спасибо, вам может подойти один из следуюших адресов");
            Console.WriteLine(Cname + date + "@" + domen);
            Console.WriteLine(Cname + datebirthday + "@" + domen);
            Console.WriteLine(Csurname + "_" + Cname + "@" + domen);
            Console.WriteLine(Csurname + "_" + Cname + date + "@" + domen);
            Console.WriteLine(Csurname + "_" + Cname + datebirthday + "@" + domen);
            Console.ReadKey();

        }


    }
}