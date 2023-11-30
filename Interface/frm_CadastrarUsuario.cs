using PrjFolhaPagamento.Entity.BancodeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHS_Folha_de_Pagamento.Interface
{
    public partial class frm_CadastrarUsuario : Form
    {

        public frm_CadastrarUsuario()
        {
            InitializeComponent();
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
        private void SalvarCadastro()
        {
            try
            {
                if ((txb_nome.Text != string.Empty) & (cb_tipo.Text != string.Empty) & (txb_login.Text != string.Empty) & (txb_senha.Text != string.Empty))
                {
                    BancoDados bancodados = new BancoDados();
                    string tabela = "\"RHS\".\"tb_usuario\"";
                    string[] colunaNomes = { "nome", "tipo", "login", "senha" };
                    object[] valores = { txb_nome.Text, cb_tipo.Text, txb_login.Text, CriptografarSenha(txb_senha.Text) };
                    bancodados.InserirDados(tabela, colunaNomes, valores);
                    MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar cadastro!", "Formulário não pode conter campos vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cadastro:\n\n" + ex.Message);
            }
        }
        //Metodo para criptografar senha
        private string CriptografarSenha(string senha)
        {
            // lógica de criptografia hashing SHA256:
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SalvarCadastro();
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
