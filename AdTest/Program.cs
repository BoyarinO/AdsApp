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
           
                context.Constraint.Add(
                    new Constraint
                    {

                   
                     TotalViews=10000,
                     AgeMin=20
                    




                    });
            
            context.SaveChanges();
            Console.WriteLine("Done");

        }
    }
}
