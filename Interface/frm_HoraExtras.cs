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
    public partial class frm_HoraExtras : Form
    {
        public frm_HoraExtras()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txb_Percentual.Text, out decimal valor) && decimal.TryParse(txb_QuantHoras.Text, out decimal valor2))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um valor válido.");
            }
        }

        private void frm_HoraExtras_Load(object sender, EventArgs e)
        {

        }
    }
}
