using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPower
{
   public abstract class Employee:Person
    {

        public int ola; 
        public double? _salary;
        public double Salary { get; set; }

        public Employee(int _Age, string _FullName, DateTime _Brithdate, Gender _Gender, DateTime _birthdate, double _Salary) :
        base(_Age, _FullName, _Brithdate, _Gender, _birthdate)
        {
          
            this.FullName = _FullName;
            this.BirthDate = _Brithdate;
            this.Gender = _Gender;
            this._birthdate = _birthdate;

            //ESTE É MEU (APENAS Employee, MAS TENHO QUE PREENCHER NO BASE OS DO PERSON, POIS EXTENDO DE LA)
            this.Salary = _Salary;

        }

      







    }
}
