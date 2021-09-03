using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMFinanciamentos.Entidades
{
    class BuscarClientes
    {
        private string nome;
        private string id;
        public BuscarClientes() { }
        public BuscarClientes(string nameForPart, string numberForPart)
        {
            PartName = nameForPart;
            PartNumber = numberForPart;
        }

        public string PartName
        {
            get { return nome; }
            set { nome = value; }
        }

        public string PartNumber
        {
            get { return id; }
            set { id = value; }
        }
    }
}
