using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPower
{
    public abstract class Person : IPrintable
    {

        public int Age { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public double Altura { get; set; }
        public DateTime _birthdate;
        private DateTime brithdate;

        public Person(int _Age, string _FullName, DateTime _Brithdate, Gender _Gender, double Altura, DateTime _birthdate)
        {

            this._birthdate = _birthdate;


        }


        public Person(string _FullName, DateTime _Brithdate, string adress, double _Altura)
        {

            this._birthdate = _Brithdate;
            this.FullName = _FullName;
            this.Altura = _Altura;

        }

        protected Person(string fullName, DateTime brithdate, Gender gender, double altura, DateTime birthdate)
        {
            FullName = fullName;
            this.brithdate = brithdate;
            Gender = gender;
            Altura = altura;
            BirthDate = birthdate;
        }

        public string Print()
        {


            return this.FullName + this.Age;
        }


        // retribui o nome do programador que foi enviado
        public string GetNome(Person p)
        {
            return p.FullName;
        }
        // retribui o nome do programador com mais de 50 anos
        public string GetNome20(Person p1)
        {
            if (p1.Age > 50)
            {
                return p1.FullName;
            }
            else {
                return "Não é possivel";
            }

        }

        public List<Person> GetTodos() {

            List<Person> listPerson = new List<Person>();

            Programmer programmer1 = new Programmer(44, "Ze toino", new DateTime(2010, 8, 18), Gender.Feminino, 210, DateTime.Now, 650);
            Programmer programmerRenato = new Programmer(26, "Renato", new DateTime(1992, 8, 18), Gender.Feminino, 205, DateTime.Now, 650);
            Programmer programmerZe = new Programmer(150, "Ze", new DateTime(1990, 8, 18), Gender.Feminino, 220, DateTime.Now, 650);

            List<Programmer> listaPaulo = new List<Programmer>();
            listaPaulo.Add(programmerZe);
            listaPaulo.Add(programmerRenato);

            List<Programmer> listaMarega = new List<Programmer>();

            List<Programmer> listaAsdrubal = new List<Programmer>();

            Manager Manager2 = new Manager(28, "Marega", new DateTime(1999, 8, 18), Gender.Masculino, 180, DateTime.Now, 1500, listaMarega);

            Manager ManagerPaulo = new Manager(50, "Paulo", new DateTime(1985, 8, 18), Gender.Feminino, 190, DateTime.Now, 1500, listaPaulo);

            Manager ManagerAsdrubal = new Manager(48, "Ausdrubal", new DateTime(1985, 5, 18), Gender.Feminino, 199, DateTime.Now, 1500, listaAsdrubal);


            listPerson.Add(programmer1);
            listPerson.Add(Manager2);
            listPerson.Add(programmerRenato);
            listPerson.Add(ManagerPaulo);
            listPerson.Add(programmerZe);
            listPerson.Add(ManagerAsdrubal);


            return listPerson;

        }

        public List<Manager> GetTodosManageres(){
            List<Manager> listaTodosManagers = new List<Manager>();

            Programmer programmer1 = new Programmer(44, "Ze toino", new DateTime(2010, 8, 18), Gender.Feminino, 210, DateTime.Now, 650);
            Programmer programmerRenato = new Programmer(26, "Renato", new DateTime(1992, 8, 18), Gender.Feminino, 205, DateTime.Now, 650);
            Programmer programmerZe = new Programmer(150, "Ze", new DateTime(1990, 8, 18), Gender.Feminino, 220, DateTime.Now, 650);

            List<Programmer> listaPaulo = new List<Programmer>();
            listaPaulo.Add(programmerZe);
            listaPaulo.Add(programmerRenato);

            List<Programmer> listaMarega = new List<Programmer>();

            List<Programmer> listaAsdrubal = new List<Programmer>();

            Manager Manager2 = new Manager(28, "Marega", new DateTime(1999, 8, 18), Gender.Masculino, 180, DateTime.Now, 1500, listaMarega);

            Manager ManagerPaulo = new Manager(50, "Paulo", new DateTime(1985, 8, 18), Gender.Feminino, 190, DateTime.Now, 1500, listaPaulo);

            Manager ManagerAsdrubal = new Manager(48, "Ausdrubal", new DateTime(1985, 5, 18), Gender.Feminino, 199, DateTime.Now, 1500, listaAsdrubal);

            listaTodosManagers.Add(Manager2);
            listaTodosManagers.Add(ManagerPaulo);
            listaTodosManagers.Add(ManagerAsdrubal);

            return listaTodosManagers;
        }


        //Devolve lista de Nomes comecados por um valor
        public List<Person>GetPesquisaNome(string valor)
        {
            List<Person> listaPersonAtual = GetTodos();
           listaPersonAtual = listaPersonAtual.Where(t => t.FullName.StartsWith(valor)).ToList();

            return listaPersonAtual;
        }
        //Devolve lista de Nomes de pessoas com mais de 35 anos
        public List<Person> GetPesquisaNomeMais35(string valor)
        {
            List<Person> listaPersonAtual = GetTodos();
            listaPersonAtual = listaPersonAtual.Where(t => t.FullName.StartsWith(valor) && t.Age > 35).ToList();

            return listaPersonAtual;
        }
        //Devolve lista de Pessoas entre idades
        public List<Person>GetEntreIdades(int idademenor, int idademaior)
        {
            List<Person> listaPersonAtual = GetTodos();
            listaPersonAtual = listaPersonAtual.Where(t => t.Age > idademenor && t.Age < idademaior).ToList();
            return listaPersonAtual;
        }
        // Pesquisa pelo final do Nome e ordena 
        public List<Person> GetPesquisaNomeoOrdenado(string valor, string ordem)
        {
            List<Person> listaPersonAtual = GetTodos();


            if (ordem == "Asc") {
                listaPersonAtual = listaPersonAtual.Where(t => t.FullName.EndsWith(valor)).OrderBy(t => t.FullName).ToList();
            }

            if (ordem == "Desc") {
                listaPersonAtual = listaPersonAtual.Where(t => t.FullName.EndsWith(valor)).OrderByDescending(t => t.FullName).ToList();
            }


            return listaPersonAtual;
        }
        //Devolve a lista Ordenada
        public List<Person> GetPesquisaOrdenado(string ordem)
        {
            List<Person> listaPersonAtual = GetTodos();


            if (ordem == "Asc")
            {
                listaPersonAtual = listaPersonAtual.OrderBy(t => t.FullName).ToList();
            }

            if (ordem == "Desc")
            {
                listaPersonAtual = listaPersonAtual.OrderByDescending(t => t.FullName).ToList();
            }


            return listaPersonAtual;
        }
        //Devolve a pessoa mais velha
        public Person GetMaiorIdade()
        {
            List<Person> listaPersonAtual = GetTodos();

            Person p = listaPersonAtual.OrderByDescending(t => t.Age).Take(1).FirstOrDefault();

            return p;
        }


        //Devolve a média das idades
        public double GetMediaDeIdades()
        {
            List<Person> listaPersonAtual = GetTodos();

            double p = listaPersonAtual.Average(t => t.Age);
            return p;

        }
        //Devolve uma lista de pessoas Femininas
        public List<Person> GetListaFemininos ()
        {
            List<Person> listaPersonAtual = GetTodos();

            listaPersonAtual = listaPersonAtual.Where(t => t.Gender == Gender.Feminino).ToList();
               
                return listaPersonAtual;
        }

        public Person GetPersonIdadeData(bool valor)
        {
                     
            //bool valor caso seja true queremos o mais velho, caso seja falso devolve o mais novo
            List<Person> listaPersonAtual = GetTodos();

            if(valor== true)
            {
                return listaPersonAtual.OrderBy(t => t.BirthDate).Take(1).FirstOrDefault();

            }
            else
            {
                return listaPersonAtual.OrderByDescending(t => t.BirthDate).Take(1).FirstOrDefault();
            }

         }

           public List<Person> GetAlturaMaiorMenor(double altura, bool valor)
        {
            List<Person> listaPersonAtural = GetTodos();
            if(valor == true)
            {
                List<Person> p = listaPersonAtural.Where(t => t.Altura > altura).ToList();
                return p;
            }

            return listaPersonAtural.Where(t => t.Altura < altura).ToList();
                            

        }

        public Manager GetManagerProgrammer (string nome)
        {
            List<Manager> listaPersonAtual = GetTodosManageres();

            Manager m = listaPersonAtual.Where(t => t.FullName == nome).FirstOrDefault();

            return m;

        }



    }



    


    public enum Gender

    {
        Feminino=2,
        Masculino=1,
        Indefenido=0
    }
}
