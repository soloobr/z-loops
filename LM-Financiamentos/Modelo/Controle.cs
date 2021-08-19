using LMFinanciamentos.DAL;

using System;

namespace LMFinanciamentos.Modelo
{
    class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha,String server)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            loginDao.server = server;

            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha)
        {
            return mensagem;
        }
        //public String buscarfuncionario(String login, String senha)
        //{
        //    LoginDaoComandos loginDao = new LoginDaoComandos();
        //    //NomeFunc = loginDao.GetFunc(login, senha);
        //    return NomeFunc;
        //}
        public String alterarsenha(String id, String login, String senha, String novasenha)
        {
            return mensagem;
        }


    }
}
