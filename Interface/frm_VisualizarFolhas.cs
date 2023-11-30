using PdfiumViewer;
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

    public partial class frm_VisualizarFolhas : Form
    {
        private string _nomeFuncionario;
        private string _id_Funcionario;
        private BancoDados bancodados = new BancoDados();
        public frm_VisualizarFolhas(string nomefuncionario, string id_funcionario)
        {
            InitializeComponent();
            this._nomeFuncionario = nomefuncionario;
            this._id_Funcionario = id_funcionario;
            GerarGrade();

            lsv_Listagem.MouseDoubleClick += Lsv_Listagem_MouseDoubleClick;
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
            lsv_Listagem.Columns.Add("Nome do Arquivo", 200).TextAlign = HorizontalAlignment.Left;
            lsv_Listagem.Columns.Add("Data de Emissão", 100).TextAlign = HorizontalAlignment.Left;
            lsv_Listagem.View = View.Details;
            PreencherLista();
        }

        private void Lsv_Listagem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lsv_Listagem.SelectedItems.Count > 0)
            {
                byte[] fileContent = (byte[])lsv_Listagem.SelectedItems[0].Tag;

                // Verifica se o conteúdo do arquivo não está vazio
                if (fileContent != null && fileContent.Length > 0)
                {
                    try
                    {
                        // Salva o conteúdo do arquivo em um local temporário
                        string tempFilePath = Path.GetTempFileName() + ".pdf";
                        File.WriteAllBytes(tempFilePath, fileContent);

                        // Abra uma nova janela para exibir o PDF
                        AbrirJanelaPDF(tempFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao abrir o arquivo PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Metodo que abre um janela para visualizar o arquivo PDF
        private void AbrirJanelaPDF(string filePath)
        {
            // Cria uma nova instância da janela para exibir o PDF
            Form janelaPDF = new Form();
            // Cria um visualizador PdfViewer para a nova janela
            PdfViewer viewer = new PdfViewer();
            viewer.Dock = DockStyle.Fill;
            // Carrega o arquivo PDF no visualizador
            using (var pdfStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                viewer.Document = PdfDocument.Load(pdfStream);
            }
            // Adiciona o visualizador à nova janela
            janelaPDF.Controls.Add(viewer);
            // Configura a nova janela
            janelaPDF.Text = "Visualizador de PDF";
            janelaPDF.Size = new System.Drawing.Size(800, 600);
            janelaPDF.ShowDialog();
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

            // Replace the following with your actual query to retrieve data
            string sqlQuery = "SELECT id, id_funcionario, nome_arquivo, data_emissao, arquivo FROM \"RHS\".\"tb_folha_pagamento\" WHERE id_funcionario = " + _id_Funcionario;

            DataTable dataTable = bancodados.Consultar(sqlQuery); // Replace with your method to retrieve data

            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["id_funcionario"].ToString());
                item.SubItems.Add(row["nome_arquivo"].ToString());
                item.SubItems.Add(row["data_emissao"].ToString());

                // Assuming the file content is stored in the "arquivo" column (adjust accordingly)
                byte[] fileContent = (byte[])row["arquivo"];
                item.Tag = fileContent; // Set the byte array as the Tag of the ListViewItem

                lsv_Listagem.Items.Add(item);
            }
        }
    }
}
