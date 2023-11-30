using PrjFolhaPagamento.Forms;
using RHS_Folha_de_Pagamento;
using RHS_Folha_de_Pagamento.Interface;

namespace RHS_Folha_de_Pagamento
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new frm_Principal("TESTE","TESTE"));
            //Application.Run(new frm_CadastroEmpresa());
            //Application.Run(new frm_FolhaPagamento());
            Application.Run(new frm_Login());
            //Application.Run(new frm_CadastrarUsuario());
            //Application.Run(new frm_CadastroFuncionario());

        }

    }
    
}