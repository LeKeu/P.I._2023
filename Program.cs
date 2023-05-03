using projeto_integrado.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            conexao_api.Init(); // criar conexão com api google
            conexao_internet.Run000(); // fazer a checagem de internet
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gerenciamento_m());
        }
    }
}
