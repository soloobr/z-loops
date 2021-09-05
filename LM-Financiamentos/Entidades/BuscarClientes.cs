using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMFinanciamentos.Entidades
{
    class BuscarClientes
    {
        private string id;
        private string nome;
        private string email;
        private string cpf;
        private string celular;
        private string nascimento;

        public BuscarClientes() { }

        public BuscarClientes(string id_cliente, string nome_cliente, string email_cliente, string cpf_cliente, string celular_cliente, string nascimento_cliente )
        {
            Id_cliente = id_cliente;
            Nome_cliente = nome_cliente;
            Email_cliente = email_cliente;
            CPF_cliente = cpf_cliente;
            Celular_cliente = celular_cliente;
            Nascimento_cliente = nascimento_cliente;
        }

        public string Id_cliente
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome_cliente
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email_cliente
        {
            get { return email; }
            set { email = value; }
        }
        public string CPF_cliente
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Celular_cliente
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Nascimento_cliente
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
    }
}
