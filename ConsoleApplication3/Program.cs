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
            int i=1;
            while (i != 0)
            {


                ClientDAO test = new ClientDAO();
                string mail = Console.ReadLine();
                test.TestMail(mail);
                Console.WriteLine(test.TestMail(mail));

                 i = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
