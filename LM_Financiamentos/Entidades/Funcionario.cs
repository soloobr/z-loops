using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Financiamentos.Entidades
{
    public class Funcionario
    {
        private string _Login_Func;
        private string _Senha_Func;
        private string _Id_func;
        private string _Nome_Func;

       // public string Id_func { get; set; }
        public string Id_func { get; set; }
        public string Nome_Func { get; set; }
        public string Login_Func { get; set; }
        public string Senha_Func { get; set; }


        public string Permision { get; set; }

        public byte[] Foto_Func { get; set; }

        public string GetId()
        {
            return Id_func;
        }
    }
}
