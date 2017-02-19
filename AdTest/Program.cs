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

          
           /* context.Client.Add(
                new Client
                {
                    Company= "AdCOmpany",
                    Contact ="323139131",
                    Email = "AdCOmpany@afm.com",
                    Login = "AdCOmpany",
                    Password = "1234",
                    

                }
                );
                context.Constraint.Add(
                    new Constraint
                    {

                   
                     TotalViews=10000,
                     AgeMin=20
                    




                    });
            
            context.SaveChanges();
            Console.WriteLine("Done");*/

        }
        internal class B
        { // Базовый класс
            public string gg;
        }
        internal class D : B
        { // Производный класс
            public string name;
            public string id;
             public D(string g,string nam,string i)
            {
                gg = g;
                name = nam;
                id = i;
            }
            public D()
            { }
        }
    }
}
