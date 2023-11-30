using PrjFolhaPagamento.Entity.BancodeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHS_Folha_de_Pagamento.Interface
{
    public partial class frm_CadastroEmpresa : Form
    {
        public frm_CadastroEmpresa()
        {
            InitializeComponent();
        }
        public frm_CadastroEmpresa(StatusStrip status, ToolStripStatusLabel toolStripStatusLabel)
        {
            InitializeComponent();

        }
        private void frm_Cadastro_Load(object sender, EventArgs e)
        {

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
            BancoDados bancodados = new BancoDados();
            try
            {
                if ((txb_Cnpj.Text != string.Empty) & (txb_razao_Social.Text != string.Empty) & (txb_Estado.Text != string.Empty) & (txb_Cidade.Text != string.Empty) & (txb_Logradouro.Text != string.Empty) & (txb_Telefone.Text != string.Empty) & (txt_Area.Text != string.Empty) & (txb_quant_Func.Text != string.Empty))
                {

                    string tabela = "\"RHS\".\"tb_empresa\"";
                    string[] colunaNomes = { "Cnpj", "Razao_Social", "Estado", "Cidade", "Endereco", "Telefone", "Area_atuacao", "Quant_Funcionario" };
                    object[] valores = { txb_Cnpj.Text, txb_razao_Social.Text, txb_Estado.Text, txb_Cidade.Text, txb_Logradouro.Text, txb_Telefone.Text, txt_Area.Text, int.Parse(txb_quant_Func.Text) };

                    bancodados.InserirDados(tabela, colunaNomes, valores);

                    MessageBox.Show("Cadastro salvo com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar cadastro!", "Formulário não pode conter campos vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro!\n\n" + ex.Message);
            }
            finally
            {
                bancodados.Desconectar();
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
