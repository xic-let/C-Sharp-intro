using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoliStaff;

namespace PoliStaff
{
	internal class Staff
	{

		//propriedades
		public string Name { get; set; }
		public int Hours { get; set; }
		public double ValperHour { get; set; }
		public double Payment { get; set; }

		//construtores
		public Staff()
		{ 
		}

		public Staff(string name, int hours, double valperhour)
		{
			Name = name;
			Hours = hours;
			ValperHour = valperhour;
			
		}

		//metodos
		public virtual void Income()
		{
			Payment = ValperHour * Hours;
		}

	}
}
