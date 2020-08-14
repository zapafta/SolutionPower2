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

      


        public Manager(int _Age, string _FullName, DateTime _Brithdate, Gender _Gender, DateTime _birthdate, double _salary ) :
         base(_Age, _FullName, _Brithdate, _Gender, _birthdate,_salary)
        {
            this.Age = _Age;
            this.BirthDate = _Brithdate;
            this.Gender = _Gender;
            this._birthdate = _birthdate;
            this.FullName = _FullName;
            this.Salary = _salary;
        }


    }
}
