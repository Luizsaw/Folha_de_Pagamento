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
    public partial class frm_Outras : Form
    {
        public frm_Outras()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txb_valor.Text, out decimal valor))
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
