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
    public partial class frm_Listagem : Form
    {

        private String nomeLista;
        private String nomeTabelaDeletar;
        private String nomeColunaDeletar;
        private List<TextBox> listaTextBoxes = new List<TextBox>();
        private BancoDados bancodados = new BancoDados();
        private List<string> nomeColunas = new List<string>();
        private List<string> nomeTabelas = new List<string>();
        public bool abrirjanela { get; set; }
        public bool habilitarViewPonto { get; set; }
        public bool flagliberarPanels { get; set; }
        public frm_Listagem()
        {
            InitializeComponent();
        }
        public frm_Listagem(string nomeLista)
        {
            InitializeComponent();
            this.nomeLista = nomeLista;
            GerarGrade();
        }
        public frm_Listagem(string nomeLista, List<TextBox> textBoxes)
        {
            InitializeComponent();
            this.nomeLista = nomeLista;
            this.listaTextBoxes = textBoxes;
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

            switch (nomeLista)
            {
                case "empresa":
                    lsv_Listagem.Columns.Add("ID", 80).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("CNPJ", 200).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Razão Social", 200).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Estado", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Endereco", 300).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Telefone", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Area de Atuação", 200).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Quantidade de Funcionários", 200).TextAlign = HorizontalAlignment.Left;
                    Buscar();
                    break;
                case "funcionario":
                    lsv_Listagem.Columns.Add("Matrícula", 60).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Nome", 300).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Cargo", 150).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Departamento", 200).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Salário Base", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Dependentes", 50).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Data de Contratação", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Carga Horária", 60).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Banco", 200).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Agência", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Conta", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("ID Empresa", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Empresa", 150).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("CNPJ", 200).TextAlign = HorizontalAlignment.Left;
                    // Percorrer as colunas do ListView
                    Buscar();
                    break;
                case "user":
                    lsv_Listagem.Columns.Add("ID", 100).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Nome", 300).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Tipo", 150).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Login", 200).TextAlign = HorizontalAlignment.Left;
                    lsv_Listagem.Columns.Add("Senha", 300).TextAlign = HorizontalAlignment.Left;
                    // Percorrer as colunas do ListView
                    Buscar();
                    break;

                default:
                    MessageBox.Show("Erro ao carregar a lista");
                    break;
            }
            lsv_Listagem.View = View.Details;
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
        private void Buscar()
        {
            string queryTratada = "'" + txb_buscar.Text + "%'";
            string sqlQuery = "";


            switch (nomeLista)
            {
                case "user":
                    nomeTabelaDeletar = "\"RHS\".\"tb_usuario\"";
                    nomeColunaDeletar = "id";
                    //T = tabela e C = coluna
                    //Tabela Empresa Cliente
                    nomeTabelas.Add("\"RHS\".\"tb_usuario\"");//T[0]
                    nomeColunas.Add("id");//C[0]
                    nomeColunas.Add("nome");//C[1]
                    nomeColunas.Add("tipo");//C[2]
                    nomeColunas.Add("login");//C[3]
                    nomeColunas.Add("senha");//C[4]

                    // Montando a query com base nos indices 
                    sqlQuery = "SELECT * FROM " + nomeTabelas[0]
                             + " WHERE " + nomeColunas[1]
                             + " LIKE " + queryTratada
                             + " OR " + nomeColunas[1]
                             + " LIKE " + queryTratada
                             + " OR " + nomeColunas[3]
                             + " LIKE " + queryTratada;
                    break;
                case "empresa":
                    nomeTabelaDeletar = "\"RHS\".\"tb_empresa\"";
                    nomeColunaDeletar = "id";
                    //T = tabela e C = coluna
                    //Tabela Empresa Cliente
                    nomeTabelas.Add("\"RHS\".\"tb_empresa\"");//T[0]
                    nomeColunas.Add("id");//C[0]
                    nomeColunas.Add("cnpj");//C[1]
                    nomeColunas.Add("razao_social");//C[2]
                    nomeColunas.Add("estado");//C[3]
                    nomeColunas.Add("endereco");//C[4]
                    nomeColunas.Add("telefone");//C[5]
                    nomeColunas.Add("area_atuacao");//C[6]
                    nomeColunas.Add("quant_funcionario");//C[7]

                    // Montando a query com base nos indices 
                    sqlQuery = "SELECT * FROM " + nomeTabelas[0]
                             + " WHERE " + nomeColunas[1]
                             + " LIKE " + queryTratada
                             + " OR " + nomeColunas[1]
                             + " LIKE " + queryTratada
                             + " OR " + nomeColunas[2]
                             + " LIKE " + queryTratada;
                    break;

                case "funcionario":
                    nomeTabelaDeletar = "\"RHS\".\"tb_funcionario\"";
                    nomeColunaDeletar = "id_funcionario";
                    //T = tabela e C = coluna
                    //tabela funcionario
                    nomeTabelas.Add("\"RHS\".\"tb_funcionario\"");//T[0]
                    nomeColunas.Add("id_funcionario");//C[0]
                    nomeColunas.Add("nome");//C[1]                 
                    nomeColunas.Add("cargo");//C[2]
                    nomeColunas.Add("departamento");//C[3]
                    nomeColunas.Add("salario_base");//C[4]
                    nomeColunas.Add("quant_dependente");//C[5]
                    nomeColunas.Add("dat_contratacao");//C[6]
                    nomeColunas.Add("carga_horaria");//C[7]

                    //tabela conta bancaria
                    nomeTabelas.Add("\"RHS\".\"tb_conta_bancaria\"");//T[1]
                    nomeColunas.Add("nome_banco");//C[8]
                    nomeColunas.Add("num_agencia");//C[9]
                    nomeColunas.Add("num_conta");//C[10]
                                                 //tabela Empresa do funcionario
                    nomeTabelas.Add("\"RHS\".\"tb_empresa\"");//T[2]
                    nomeColunas.Add("id");//C[11]
                    nomeColunas.Add("razao_social");//C[12]
                    nomeColunas.Add("cnpj");//C[13]

                    // Montando a query com base nos indices 
                    sqlQuery = "SELECT "
                             + "t1." + nomeColunas[0] + ", "
                             + "t1." + nomeColunas[1] + ", "
                             + "t1." + nomeColunas[2] + ", "
                             + "t1." + nomeColunas[3] + ", "
                             + "t1." + nomeColunas[4] + ", "
                             + "t1." + nomeColunas[5] + ", "
                             + "t1." + nomeColunas[6] + ", "
                             + "t1." + nomeColunas[7] + ", "
                             + "t2." + nomeColunas[8] + ", "
                             + "t2." + nomeColunas[9] + ", "
                             + "t2." + nomeColunas[10] + ", "
                             + "t3." + nomeColunas[11] + ", "
                             + "t3." + nomeColunas[12] + ", "
                             + "t3." + nomeColunas[13]
                             + " FROM "
                             + nomeTabelas[0] + " t1 "
                             + " JOIN "
                             + nomeTabelas[1] + " t2 " + " ON t1.num_conta"
                             + " = " + "t2." + nomeColunas[10]
                             + " JOIN "
                             + nomeTabelas[2] + " t3 " + " ON t1.id_empresa"
                             + " = " + "t3." + nomeColunas[11]
                             + " WHERE " + "t1." + nomeColunas[1]
                             + " LIKE " + queryTratada
                             + " OR " + "t3." + nomeColunas[12]
                             + " LIKE " + queryTratada;
                    break;
            }
            bancodados.ExecutarQueryListView(sqlQuery, lsv_Listagem, nomeColunas);
            abrirjanela = bancodados.estarConectado;
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void abrirJanela(Form form)
        {
            form.ShowDialog();
        }
        private void lsv_Listagem_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem clickedItem = lsv_Listagem.SelectedItems[0];

            if (lsv_Listagem.SelectedItems.Count > 0 && nomeLista == "funcionario" && abrirjanela)
            {
                // Atribuir os valores aos campos de texto
                listaTextBoxes[0].Text = clickedItem.SubItems[0].Text; //id do funcionario
                listaTextBoxes[1].Text = clickedItem.SubItems[1].Text; //nome do funcionario
                listaTextBoxes[2].Text = clickedItem.SubItems[2].Text;
                listaTextBoxes[3].Text = clickedItem.SubItems[6].Text;
                listaTextBoxes[4].Text = clickedItem.SubItems[3].Text;
                listaTextBoxes[5].Text = clickedItem.SubItems[4].Text;
                listaTextBoxes[6].Text = clickedItem.SubItems[5].Text;
                listaTextBoxes[7].Text = clickedItem.SubItems[7].Text;
                listaTextBoxes[8].Text = clickedItem.SubItems[8].Text;
                listaTextBoxes[9].Text = clickedItem.SubItems[9].Text;
                listaTextBoxes[10].Text = clickedItem.SubItems[10].Text;
                listaTextBoxes[11].Text = clickedItem.SubItems[11].Text;
                listaTextBoxes[12].Text = clickedItem.SubItems[12].Text;
                listaTextBoxes[13].Text = clickedItem.SubItems[13].Text;
                flagliberarPanels = true;
                this.Close();
            }
            else if(habilitarViewPonto)
            {
               abrirJanela(new frm_FolhaPonto(clickedItem.SubItems[1].Text, clickedItem.SubItems[0].Text));
               
            }
            else
            {
                abrirJanela(new frm_VisualizarFolhas(clickedItem.SubItems[1].Text, clickedItem.SubItems[0].Text));
            }
            
        }
        private void frm_Listagem_Load(object sender, EventArgs e)
        {

        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            bool deletado = false;
            foreach (ListViewItem item in lsv_Listagem.Items)
            {
                if ((item.Checked) & (item.Text == "1"))
                {
                    MessageBox.Show("Este item não pode ser apagado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (item.Checked)
                {
                    if (nomeLista == "funcionario")
                    {
                        //recupera o valor da chave estrangeira na tb_conta_bancaria antes de deletar o registro do funcionario
                        string query = "SELECT num_conta FROM \"RHS\".\"tb_funcionario\" WHERE id_funcionario = " + "'" + item.Text + "'";
                        string chavePrimariaConta = bancodados.ObterValor(query);

                        //deleta registro da tabela tb_folha_pagamento que possui uma chave estrangeira da tb_funcionario
                        deletado = bancodados.DeletarRegistro("\"RHS\".\"tb_folha_pagamento\"", "id_funcionario", int.Parse(item.Text));

                        //deleta registro da tabela tb_funcionario
                        deletado = bancodados.DeletarRegistro(nomeTabelaDeletar, nomeColunaDeletar, int.Parse(item.Text));

                        //deleta registro da tabela tb_conta_bancaria que é chave estrangeira na tb_funcionario
                        deletado = bancodados.DeletarRegistro("\"RHS\".\"tb_conta_bancaria\"", "num_conta", chavePrimariaConta);


                    }
                    else
                    {
                        deletado = bancodados.DeletarRegistro(nomeTabelaDeletar, nomeColunaDeletar, int.Parse(item.Text));
                    }
                    if (deletado)
                    {
                        MessageBox.Show("Cadastro deletado com sucesso !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lsv_Listagem.Items.Remove(item);
                        flag = false;
                        break;
                    }

                }
                else
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Nenhum item selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            flagliberarPanels = false;
            this.Close();
        }
    }
}
