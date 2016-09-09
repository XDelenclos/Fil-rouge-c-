using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Entrer une adresse email :");
            text = Console.ReadLine();
            ClientDAO test = new ClientDAO();
            test.TestMail(text);
            Console.ReadLine();
        }
    }
}
