﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPower
{
   public class Programmer:Employee
    {





        public Programmer(int _Age, string _FullName, DateTime _Brithdate, Gender _Gender, DateTime _birthdate, double _salary) :
        base( _Age, _FullName, _Brithdate, _Gender, _birthdate, _salary)
        {
            this.Age = _Age;
            this.FullName = _FullName;
            this.BirthDate = _Brithdate;
            this.Gender = _Gender;
            this._birthdate = _birthdate;
            this.Salary = _salary;


        }

    }
}
