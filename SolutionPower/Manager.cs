using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPower
{
    public class Manager : Employee
    {


        public int NumberOfProgrammer { get; set; }


        public List<Programmer> Programmers { get; set; }

      


        public Manager(int _Age, string _FullName, DateTime _Brithdate, Gender _Gender, double _Altura, DateTime _birthdate, double _salary, List<Programmer> _programmers ) :
         base(_Age, _FullName, _Brithdate, _Gender, _Altura, _birthdate,_salary)
        {
            this.Age = _Age;
            this.BirthDate = _Brithdate;
            this.Gender = _Gender;
            this.Altura = _Altura;
            this._birthdate = _birthdate;
            this.FullName = _FullName;
            this.Salary = _salary;
            this.Programmers = _programmers;
        }


    }
}
