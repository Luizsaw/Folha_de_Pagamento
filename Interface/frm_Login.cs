using Npgsql;
using PrjFolhaPagamento.Entity.BancodeDados;
using RHS_Folha_de_Pagamento;
using RHS_Folha_de_Pagamento.Entity;
using RHS_Folha_de_Pagamento.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjFolhaPagamento.Forms
{
    public partial class frm_Login : Form
    {
        private BancoDados banco = new BancoDados();
        private string _userLogado;
        private string _tipoUser;
        public frm_Login()
        {
            InitializeComponent();
        }
        private void btn_Logar_Click(object sender, EventArgs e)
        {
            _userLogado = banco.buscarCredenciaisUser(txt_username.Text, txt_senha.Text);
            //U.N.A = Usuario Não Autenticado
            if (_userLogado != "U.N.A")
            {
                //recupera o tipo de acesso do usuario logado
                string query = "SELECT tipo FROM  \"RHS\".\"tb_usuario\" WHERE login = " + "'" + _userLogado + "'";
                _tipoUser = banco.ObterValor(query);

                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //abre a janela usando Threads
                Thread novaThread = new Thread(AbrirForm);
                novaThread.SetApartmentState(ApartmentState.STA); // Defina o ApartmentState para STA (Single-Threaded Apartment)
                novaThread.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login falhou. Verifique o nome de usuário e senha.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AbrirForm()
        {

            Application.Run(new frm_Principal(_userLogado, _tipoUser));
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pintar_Borda(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            Color.White, 1, ButtonBorderStyle.Solid, // left
            Color.White, 1, ButtonBorderStyle.Solid, // top
            Color.White, 1, ButtonBorderStyle.Solid, // right
            Color.White, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
