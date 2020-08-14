using SolutionPower;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Employee> list = new List<Employee>();

            Programmer programmer = new Programmer(29, "Joao",DateTime.Now, Gender.Masculino, DateTime.Now,500);
           

            list.Add(programmer);
            Programmer programmer1 = new Programmer(44, "Manel", DateTime.Now, Gender.Feminino, DateTime.Now,650);
            Manager Manager2 = new Manager(44, "MANAGERPWOER", DateTime.Now, Gender.Feminino, DateTime.Now,1500);
            list.Add(programmer1);
            list.Add(Manager2);




            Console.WriteLine(Manager2.Print());

            DateTime dateTime = DateTime.Now;



            string[] firstnames = { "Scott", "Steve", "Ken", "Joe",
 "John", "Alex", "Chuck", "Sarah"};


            IEnumerable<Employee> val = from fn in list
                                      where fn.Age>500
                                      select fn;


         

            foreach (var programador in val)
            {
                Console.WriteLine(programador.FullName);

            }

            int a = 1;


        }
    }
}
