using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPower
{
    public class Customer : Person
    {

        public string Address { get; set; }


        public Customer(int _Age, string _FullName, DateTime _Brithdate, Gender _Gender, DateTime _birthdate, string _Adress) :
            base(_Age, _FullName, _Brithdate, _Gender, _birthdate)
        {
            this.Age = _Age;
            this.FullName = _FullName;
            this.BirthDate = _Brithdate;
            this.Gender = _Gender;
            this._birthdate = _birthdate;

            //ESTE É MEU (APENAS CUSTOMER, MAS TENHO QUE PREENCHER NO BASE OS DO PERSON, POIS EXTENDO DE LA)
            this.Address = _Adress;


        }

  

    }
}
