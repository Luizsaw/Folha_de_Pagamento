using RHS_Folha_de_Pagamento.Interface;
using PrjFolhaPagamento.Forms;

namespace RHS_Folha_de_Pagamento
{
    public partial class frm_Principal : Form
    {
        private string _user;
        private string _tipoUser;

        public frm_Principal(string usuario, string tipoUser)
        {
            InitializeComponent();
            MenuStrip_Personalizar(menuStrip1);
            this._user = usuario;
            this.lbl_user.Text = _user;
            this._tipoUser = tipoUser;
            this.lbl_tipo.Text = _tipoUser;

        }
        private void MenuStrip_Personalizar(MenuStrip menu)
        {
            // Define a fonte desejada (opcional)
            Font fonte = new Font("Arial", 10);
        }
        private void abrirJanela(Form form)
        {
            form.ShowDialog();
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

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirJanela(new frm_FolhaPagamento());
            pn_perfil.Visible = false;
        }

        private void pic_login_Click(object sender, EventArgs e)
        {
            if (!pn_perfil.Visible)
            {
                pn_perfil.Visible = true;
            }
            else
            {
                pn_perfil.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread novaThread = new Thread(AbrirForm);
            novaThread.SetApartmentState(ApartmentState.STA); // Defina o ApartmentState para STA (Single-Threaded Apartment)
            novaThread.Start();
            this.Close();
        }
        private void AbrirForm()
        {
            Application.Run(new frm_Login());
        }

        private void ts_cadastrarUser_Click(object sender, EventArgs e)
        {
            abrirJanela(new frm_CadastrarUsuario());
        }

        private void listaDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirJanela(new frm_Listagem("user"));

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirJanela(new frm_CadastroEmpresa());
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirJanela(new frm_Listagem("empresa"));
        }

        private void listaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Listagem viewlistaFuncionarios = new frm_Listagem("funcionario");
            viewlistaFuncionarios.abrirjanela = false;
            abrirJanela(viewlistaFuncionarios);
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abrirJanela(new frm_CadastroFuncionario());
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {


            if (_tipoUser == "Administrador")
            {
                this.ts_usuario.Enabled = false;
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Listagem viewlistaFuncionarios = new frm_Listagem("funcionario");
            viewlistaFuncionarios.abrirjanela = false;
            viewlistaFuncionarios.habilitarViewPonto = true;
            abrirJanela(viewlistaFuncionarios);
        }

        private void exibirFolhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Listagem viewfolhapagamento = new frm_Listagem("funcionario");
            viewfolhapagamento.abrirjanela = false;
            //viewlistaFuncionarios.habilitarViewPonto = true;
            abrirJanela(viewfolhapagamento);
        }
    }
}
