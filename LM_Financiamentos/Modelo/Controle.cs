using LM_Financiamentos.DAL;
using LM_Financiamentos.Entidades;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Financiamentos.Modelo
{
    class Controle
    {
        public bool tem;
        public String mensagem = "", NomeFunc, Login, Senha;

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha)
        {
            return mensagem;
        }
        public String buscarfuncionario(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            //NomeFunc = loginDao.GetFunc(login, senha);
            return NomeFunc;
        }
        public String alterarsenha(String id, String login, String senha, String novasenha)
        {
            return mensagem;
        }


    }
}
