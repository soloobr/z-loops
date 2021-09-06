using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMFinanciamentos.Entidades
{
    class BuscarConjuges
    {
        private string id;
        private string nome;
        private string email;
        private string cpf;
        private string celular;
        private string nascimento;

        public BuscarConjuges() { }

        public BuscarConjuges(string id_conjuge, string nome_conjuge, string email_conjuge, string cpf_conjuge, string celular_conjuge, string nascimento_conjuge )
        {
            Id_conjuge = id_conjuge;
            Nome_conjuge = nome_conjuge;
            Email_conjuge = email_conjuge;
            CPF_conjuge = cpf_conjuge;
            Celular_conjuge = celular_conjuge;
            Nascimento_conjuge = nascimento_conjuge;
        }

        public string Id_conjuge
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome_conjuge
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email_conjuge
        {
            get { return email; }
            set { email = value; }
        }
        public string CPF_conjuge
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Celular_conjuge
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Nascimento_conjuge
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
    }
}
