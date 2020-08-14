using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPower
{
 public abstract class Person: IPrintable
    {

        public int Age { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public DateTime _birthdate;
        private DateTime brithdate;

        public Person(int _Age, string _FullName, DateTime _Brithdate, Gender _Gender, DateTime _birthdate)
        {
            
            this._birthdate = _birthdate;


        }


        public Person(string _FullName, DateTime _Brithdate, string adress)
        {

            this._birthdate = _Brithdate;
            this.FullName = _FullName;


        }

        protected Person(string fullName, DateTime brithdate, Gender gender, DateTime birthdate)
        {
            FullName = fullName;
            this.brithdate = brithdate;
            Gender = gender;
            BirthDate = birthdate;
        }

        public string Print()
        {


            return this.FullName + this.Age;
        }



    }



    


    public enum Gender

    {
        Feminino=2,
        Masculino=1,
        Indefenido=0
    }
}
