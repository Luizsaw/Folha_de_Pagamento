using PrjFolhaPagamento.Entity.BancodeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHS_Folha_de_Pagamento.Interface
{
    public partial class frm_CadastroFuncionario : Form
    {
        private string _coluna;
        private string _query;

        BancoDados bancodados = new BancoDados();
        public frm_CadastroFuncionario()
        {
            InitializeComponent();
        }
        private void frm_CadastroFuncionario_Load(object sender, EventArgs e)
        {
            _coluna = "razao_social";
            _query = "SELECT " + _coluna + " FROM \"RHS\".\"tb_empresa\"";
            bancodados.PreencherComboBox(_query, _coluna, cb_empresa);
        }
        private void SalvarCadastro()
        {

            try
            {
                if ((cb_empresa.Text != string.Empty) & (txb_nome.Text != string.Empty) & (cb_status.Text != string.Empty) & (mtxb_dat_nascimento.Text != string.Empty) & (mtxb_cpf.Text != string.Empty) & (mtxb_rg.Text != string.Empty) & (txb_email.Text != string.Empty) & (txb_Telefone.Text != string.Empty) & (txb_Logradouro.Text != string.Empty) & (txb_Estado.Text != string.Empty) & (txb_Cidade.Text != string.Empty) & (txb_cargo.Text != string.Empty) & (txb_departamento.Text != string.Empty) & (txb_salario.Text != string.Empty) & (txb_quant_dep.Text != string.Empty) & (mtxb_dat_contrat.Text != string.Empty) & (txb_carga_hora.Text != string.Empty) & (txb_num_conta.Text != string.Empty) & (txb_num_agencia.Text != string.Empty) & (txb_nome_banco.Text != string.Empty))
                {
                    // tb_conta_bancaria chave estrangeira
                    string tabelaBancaria = "\"RHS\".\"tb_conta_bancaria\"";
                    string[] colunaNomes2 = { "num_conta", "num_agencia", "nome_banco" };
                    object[] valores2 = { txb_num_conta.Text, txb_num_agencia.Text, txb_nome_banco.Text };

                    bancodados.InserirDados(tabelaBancaria, colunaNomes2, valores2);

                    string tabela = "\"RHS\".\"tb_funcionario\"";
                    string[] colunaNomes = { "nome", "status", "dat_nascimento", "cpf", "rg", "email", "telefone", "endereco", "estado", "cidade", "cargo", "departamento", "salario_base", "quant_dependente", "dat_contratacao", "carga_horaria", "id_empresa", "num_conta" };
                    object[] valores = { txb_nome.Text, cb_status.Text, mtxb_dat_nascimento.Text, mtxb_cpf.Text, mtxb_rg.Text, txb_email.Text, txb_Telefone.Text, txb_Logradouro.Text, txb_Estado.Text, txb_Cidade.Text, txb_cargo.Text, txb_departamento.Text, converterStringDecimal(txb_salario.Text), int.Parse(txb_quant_dep.Text), mtxb_dat_contrat.Text, converterStringDecimal(txb_carga_hora.Text), bancodados.retornarIdEmpresa("\"RHS\".\"tb_empresa\"", "razao_social", cb_empresa.Text), txb_num_conta.Text };

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
        static decimal converterStringDecimal(string input)
        {
            if (decimal.TryParse(input, out decimal numericValue))
            {
                // Se a conversão for bem-sucedida, retorna o valor com duas casas decimais
                return Math.Round(numericValue, 2);
            }
            else
            {
                // Se a conversão falhar, pode-se tratar ou lançar uma exceção, dependendo dos requisitos
                throw new ArgumentException("Formato inválido para o número.");
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SalvarCadastro();
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

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
