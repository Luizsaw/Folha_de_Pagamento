using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHS_Folha_de_Pagamento.Interface
{
    public partial class frm_PlanoSaude : Form
    {
        private double Salario;
        public frm_PlanoSaude(double salario)
        {
            InitializeComponent();
            this.Salario = salario;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if ((decimal.TryParse(txb_valor.Text, out decimal valor)) && (double.Parse(txb_valor.Text) <= (Salario * 0.3)))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um valor válido.");
            }
        }

        private void frm_PlanoSaude_Load(object sender, EventArgs e)
        {

        }
    }
}
