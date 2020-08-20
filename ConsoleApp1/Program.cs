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

            user 2181898
            IB64M3FB


            List<Employee> list = new List<Employee>();
            List<Programmer> pro = new List<Programmer>();
            Programmer programmer = new Programmer(29, "Joao",DateTime.Now, Gender.Masculino, 210, DateTime.Now,500);
           

            list.Add(programmer);
            Programmer programmer1 = new Programmer(44, "Manel", DateTime.Now, Gender.Feminino, 190, DateTime.Now,650);
            Manager Manager2 = new Manager(44, "MANAGERPWOER", DateTime.Now, Gender.Feminino, 205, DateTime.Now,1500,pro);
            list.Add(programmer1);
            list.Add(Manager2);




            Console.WriteLine(Manager2.Print());

            DateTime dateTime = DateTime.Now;



            string[] firstnames = { "Scott", "Steve", "Ken", "Joe",
 "John", "Alex", "Chuck", "Sarah"};


            IEnumerable<Employee> val = from fn in list
                                      where fn.Age>500
                                      select fn;





            //Mostrar nomes 
            //foreach (var item in programmer1.GetPesquisaNome("Ze"))
            //{
            //    Console.WriteLine(item.FullName + "-" + item.Age);
            //}

            //Mostrar nomes com mais 35 anos
            //foreach (var item in programmer1.GetPesquisaNomeMais35("Ze"))
            //{
            //    Console.WriteLine("Nome: " + item.FullName + "Idade: " + item.Age);
            //}

            //Mostrar Nomes entre idades
            //foreach (var item in programmer1.GetEntreIdades(25, 34))
            //{
            //    Console.WriteLine("Nome: " + item.FullName + "Idade: " + item.Age);
            //}

            //Mostrar Nomes e de ordem Asc ou Desc
            //  foreach (var item in programmer1.GetPesquisaNomeoOrdenado("ega", "Asc"))
            //{
            //    Console.WriteLine("Nome: " + item.FullName + "Idade: " + item.Age);
            //}

            //foreach (var item in programmer1.GetPesquisaOrdenado("Desc"))
            //{
            //    Console.WriteLine("Nome: " + item.FullName + "Idade: " + item.Age);
            //}

            //Mostra o que tem maior Idade
            //Console.WriteLine(programmer1.GetMaiorIdade().FullName + programmer1.GetMaiorIdade().Age);

            //Mostra a média de Idades
            //Console.WriteLine("O minha média é: " + programmer1.GetMediaDeIdades().ToString("#.##"));

            //Mostra lista de Femininos
            //Console.WriteLine("A minha lista de Femininos é: ");
            //foreach (var item in programmer1.GetListaFemininos())
            //{

            //    Console.WriteLine(item.FullName + item.Age);
            //} 

            //Devolve o mais velho ou o mais novo
            //Console.WriteLine(programmer1.GetPersonIdadeData(false).BirthDate + "-" + (DateTime.Now-programmer1.GetPersonIdadeData(false).BirthDate).Days/365 + "Anos");

            //Devolve a Person se altura maior que 200 e sor verdadeiro, ou menor de 190 se for falso
            //foreach (var item in programmer1.GetAlturaMaiorMenor(190, false))
            //{
            //    Console.WriteLine("A lista por altura é: " + item.FullName + item.Altura);
            //}

            //Devolve lista de Programadores de um Manager
            Manager auxiliar = programmer1.GetManagerProgrammer("Paulo");
            if (auxiliar == null)
            {
                Console.WriteLine("Não encontrei");
            }
            else {
                Console.WriteLine("Para o Manager" + auxiliar.FullName);
                foreach (var item in auxiliar.Programmers)
                {
                    Console.WriteLine(item.FullName);
                }            
                }
                    
            foreach (var programador in val)
            {
                Console.WriteLine(programador.FullName);

            }

            int a = 1;


        }
    }
}
