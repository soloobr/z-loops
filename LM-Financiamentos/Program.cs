using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Login());
            //Application.Run(new Form_Principal());
            //Application.Run(new Form_Cadastro_Processos());
            //Application.Run(new Form_Controle_Documento());
            //Application.Run(new Form_Controle_cliente());
            // Application.Run(new Form_Cadastro_cliente());
            // Application.Run(new Form_Dados_Processos());
            //Application.Run(new Form_Controle_Processo());

            //AutoUpdater.Initialize("https://lmfinanciamentos.com.br/Config.json", Application.ProductVersion);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
            //AutoUpdater.Instance.Stop();
            //AutoUpdater.Instance.UpdateView();
            
            
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        }
    }
}
