using PrjFolhaPagamento.Entity.BancodeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RHS_Folha_de_Pagamento.Interface
{
    public partial class frm_SalarioFamilia : Form
    {
        private string _coluna;
        private string _query;

        BancoDados bancoDados = new BancoDados();

        public frm_SalarioFamilia()
        {
            InitializeComponent();
        }
        private void cb_Ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            _query = "SELECT valor_unit FROM \"RHS\".\"tb_salario_familia\" WHERE mes_ano_vigente = " + "'" + cb_Ano.Text + "'";
            txb_Valorunit.Text = bancoDados.ObterValor(_query);

            _query = "SELECT faixa_monetaria_min FROM \"RHS\".\"tb_salario_familia\" WHERE mes_ano_vigente = " + "'" + cb_Ano.Text + "'";
            txb_Remunde.Text = bancoDados.ObterValor(_query);

            _query = "SELECT faixa_monetaria_max FROM \"RHS\".\"tb_salario_familia\" WHERE mes_ano_vigente = " + "'" + cb_Ano.Text + "'";
            txb_Remunate.Text = bancoDados.ObterValor(_query);

            txb_Numfilhos.Enabled = true;
        }

        private void frm_SalarioFamilia_Load(object sender, EventArgs e)
        {
            _coluna = "mes_ano_vigente";
            _query = "SELECT " + _coluna + " FROM \"RHS\".\"tb_salario_familia\"";
            bancoDados.PreencherComboBox(_query, _coluna, cb_Ano);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(txb_Numfilhos.Text, out decimal valor))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um valor válido.");
            }
        }
    }
}
