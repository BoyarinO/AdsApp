using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdLibrary;

namespace AdTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ADSDBEntities context = new ADSDBEntities();
            context.Client.Add(
                new Client
                {
                    Id=1,
                    Name = "Vasya",
                    Password="123321",
                    Login="vasek",
                    Age="18",
                    Sex="Male",
                    Bill=13313,
                    Email="vasya@mail",
                    Money=0,
                    Views=0
           


    });
            context.SaveChanges();
            Console.WriteLine("Done");

        }
    }
}
