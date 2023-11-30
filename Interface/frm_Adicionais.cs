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
    public partial class frm_Adicionais : Form
    {
        public frm_Adicionais()
        {
            InitializeComponent();
        }

        private void frm_Adicionais_Load(object sender, EventArgs e)
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
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tb_valor.Text, out decimal valor))
            {
                tb_valor.Text = string.Empty;

            }
            if ((!decimal.TryParse(txb_cargaHoraria.Text, out decimal valor2)) &&
                (!decimal.TryParse(txb_horas.Text, out decimal valor3)) &&
                (!decimal.TryParse(txb_percentual.Text, out decimal valor4)))
            {
                txb_cargaHoraria.Text = string.Empty;
                txb_horas.Text = string.Empty;
                txb_percentual.Text = string.Empty;

            }

            this.Close();
        }
    }
}
