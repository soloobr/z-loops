using LMFinanciamentos.Apresentacao;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Login());
            //Application.Run(new Form_Principal());
            Application.Run(new Form_Cadastro_Documentos());
        }
    }
}
