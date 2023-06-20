using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoliStaff;

namespace PoliStaff
{
   internal class substaff : Staff
    {
        //parametros
        //public double addCharge { get; set; }
        public double Bonus { get; set; }

        //contrutores

        public substaff() { }
        public substaff (string name,int hours, double valueperhour, double bonus) 
            : base (name, hours, valueperhour)
        {
            //addCharge = addcharge;
            Bonus = bonus;
        }


        public override void Income()
        {
            base.Income();
            Payment = Payment + Bonus;


        }
    }
}
