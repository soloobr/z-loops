using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMFinanciamentos.Entidades
{
    public class Servidor
    {
        public string Nome_Server { get; set; }
        public string id_Server { get; set; }
        public string ServerFilesPath_Server { get; set; }




        public string GetId()
        {
            return id_Server;
        }
    }
}
