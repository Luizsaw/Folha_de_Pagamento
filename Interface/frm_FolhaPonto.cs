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

namespace RHS_Folha_de_Pagamento.Interface
{
    public partial class frm_FolhaPonto : Form
    {
        private string _nomeFuncionario;
        private string _id_Funcionario;
        private BancoDados bancodados = new BancoDados();
        private List<string> nomeColunas = new List<string>();
        private List<string> nomeTabelas = new List<string>();
        public frm_FolhaPonto(string nomefuncionario, string id_funcionario)
        {
            InitializeComponent();
            this._nomeFuncionario = nomefuncionario;
            this._id_Funcionario = id_funcionario;
            GerarGrade();
        }

        private void GerarGrade()
        {
            lsv_Listagem.LabelEdit = true;
            lsv_Listagem.AllowColumnReorder = true;
            lsv_Listagem.FullRowSelect = true;
            lsv_Listagem.GridLines = true;
            lsv_Listagem.Scrollable = true;
            lsv_Listagem.BackColor = Color.FromArgb(92, 111, 126);
            lsv_Listagem.HeaderStyle = ColumnHeaderStyle.Nonclickable; // Impede que o cabeçalho seja clicável
            lsv_Listagem.BackColor = Color.FromArgb(186, 194, 204); // Altera a cor de fundo do cabeçalho
            lsv_Listagem.ForeColor = Color.FromArgb(45, 57, 69); // Altera a cor do texto do cabeçalho para preto
            lsv_Listagem.Columns.Add("ID", 60).TextAlign = HorizontalAlignment.Left;
            lsv_Listagem.Columns.Add("ID do Funcionário", 150).TextAlign = HorizontalAlignment.Left;
            lsv_Listagem.Columns.Add("Data", 100).TextAlign = HorizontalAlignment.Left;
            lsv_Listagem.Columns.Add("Horário", 100).TextAlign = HorizontalAlignment.Left;
            lsv_Listagem.Columns.Add("Tipo", 150).TextAlign = HorizontalAlignment.Left;
            lsv_Listagem.View = View.Details;
            PreencherLista();
        }


        private void btn_fechar_Click(object sender, EventArgs e)
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
        private void PreencherLista()
        {
            lbl_nome.Text = _nomeFuncionario;
            string sqlQuery = "";
            nomeColunas.Add("id");
            nomeColunas.Add("id_funcionario");
            nomeColunas.Add("data");
            nomeColunas.Add("hora");
            nomeColunas.Add("tipo");
            sqlQuery = "SELECT * FROM \"RHS\".\"tb_registro_ponto\"  WHERE id_funcionario = " + _id_Funcionario;
            bancodados.exibirRegistroPonto(sqlQuery, lsv_Listagem, nomeColunas);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = monthCalendar1.SelectionStart;
            string dataFormatada = dataSelecionada.ToString("dd/MM/yyyy");
            string sqlQuery = "";
            nomeColunas.Add("id");
            nomeColunas.Add("id_funcionario");
            nomeColunas.Add("data");
            nomeColunas.Add("hora");
            nomeColunas.Add("tipo");
            sqlQuery = "SELECT * FROM \"RHS\".\"tb_registro_ponto\"  WHERE id_funcionario = " + _id_Funcionario
            + " AND data = " + "'" + dataFormatada + "'";
            //+ " OR " + nomeColunas[1]
            //+ " LIKE " + queryTratada
            //+ " OR " + nomeColunas[2]
            //+ " LIKE " + queryTratada;
            bancodados.exibirRegistroPonto(sqlQuery, lsv_Listagem, nomeColunas);
        }
    }
}
