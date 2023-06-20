using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using contratos.Entities.Enums;
using contratos.Entities;

namespace contratos.Entities
{
    internal class Departamento
    {

        //Propriedades do departement
        public string DepName {get; set;}

        //construtores 
        public Departamento()
        {

        }

        //este construtor recebe por parametro umargumento name
        public Departamento (string depname)
        {
            DepName = depname;
        }   
    }
}
