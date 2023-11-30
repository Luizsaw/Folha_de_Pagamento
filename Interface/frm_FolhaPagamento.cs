using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using PrjFolhaPagamento.Entity;
using System.Collections;
using PrjFolhaPagamento.Entity.BancodeDados;
using System.Data.SqlClient;
using PrjFolhaPagamento.Entity.FollhaPagamento;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp;
using RHS_Folha_de_Pagamento.Entity;
using System.Drawing.Text;

namespace RHS_Folha_de_Pagamento.Interface
{
    public partial class frm_FolhaPagamento : Form
    {

        private double _totalRendimentos = 0;
        private double _totalDescontos = 0;
        private double _salario = 0;
        private double _salarioLiquido = 0;
        private double _baseCalculoIR = 0;
        private double _descDependente = 0;
        private double _descImpostoRenda = 0;
        private double _descInss = 0;
        private double _descPensao = 0;
        private bool _atualizarLista = false;

        List<TextBox> listaTextBoxes = new List<TextBox>();
        FolhaPagamento folha = new FolhaPagamento();


        public frm_FolhaPagamento()
        {
            InitializeComponent();
            GerarGrade();
            configurarToolTip();
        }

        private void configurarToolTip()
        {
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 200;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Nova forma de cálculo, a partir de maio de 2023.";
            toolTip1.SetToolTip(pb_Ajuda, "Como uma alternativa às deduções já existentes,como previdência, dependentes, pensão\n alimentícia, entre outros,o contribuinte pode optar por usar desconto simplificado\n mensal, correspondente a 25% da faixa inicial da tabela progressiva IRRF. ");
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
        private void GerarGrade()
        {
            lsv_Lancamentos.LabelEdit = true;
            lsv_Lancamentos.AllowColumnReorder = true;
            lsv_Lancamentos.FullRowSelect = true;
            lsv_Lancamentos.GridLines = true;
            lsv_Lancamentos.Scrollable = true;
            lsv_Lancamentos.BackColor = Color.FromArgb(92, 111, 126);
            lsv_Lancamentos.HeaderStyle = ColumnHeaderStyle.Nonclickable; // Impede que o cabeçalho seja clicável
            lsv_Lancamentos.BackColor = Color.FromArgb(186, 194, 204); // Altera a cor de fundo do cabeçalho
            lsv_Lancamentos.ForeColor = Color.FromArgb(45, 57, 69); // Altera a cor do texto do cabeçalho para preto
            lsv_Lancamentos.Font = new System.Drawing.Font("Arial", 12);
            lsv_Lancamentos.Columns.Add("Descrição", 354).TextAlign = HorizontalAlignment.Center;
            lsv_Lancamentos.Columns.Add("Referência", 140).TextAlign = HorizontalAlignment.Center;
            lsv_Lancamentos.Columns.Add("Vencimentos", 130).TextAlign = HorizontalAlignment.Center;
            lsv_Lancamentos.Columns.Add("Descontos", 130).TextAlign = HorizontalAlignment.Center;
            lsv_Lancamentos.View = View.Details;

        }
        private void abrirJanela(Form form)
        {
            form.ShowDialog();
        }
        private void cb_Remuneracao_SelectedIndexChanged(object sender, EventArgs e)
        {
            folha.cargaHoraMensal = double.Parse(this.txb_CargaHora.Text);

            switch (cb_Remun.Text)
            {
                case "Hora Extras":
                    folha.calcularFolha("horasExtras", _salario, lsv_Lancamentos);
                    break;
                case "Salario Familia":
                    folha.calcularFolha("salarioFamilia", _salario, lsv_Lancamentos);
                    break;
                case "Outros":
                    folha.calcularFolha("outrosrem", _salario, lsv_Lancamentos);
                    break;
                case "Adicionais":
                    folha.calcularFolha("adicionais", _salario, lsv_Lancamentos);
                    break;
            }
            atualizarListView();
        }
        private void cb_Deducao_SelectedIndexChanged(object sender, EventArgs e)
        {
            folha.cargaHoraMensal = double.Parse(this.txb_CargaHora.Text);
            switch (cb_Deducao.Text)
            {
                case "Vale Transporte":
                    folha.calcularFolha("valeTransporte", _salario, lsv_Lancamentos);
                    break;
                case "Faltas":
                    folha.calcularFolha("faltas", _salario, lsv_Lancamentos);
                    break;
                case "Atrasos":
                    folha.calcularFolha("atrasos", _salario, lsv_Lancamentos);
                    break;
                case "Plano de Saúde":
                    folha.calcularFolha("planosaude", _salario, lsv_Lancamentos);
                    break;
                case "Outros":
                    folha.calcularFolha("outrosded", _salario, lsv_Lancamentos);
                    break;
            }

            calcularTotalDescontos();
            calcularSalarioLiquido();

            if (_atualizarLista == true)
                atualizarListView();
        }
        private void cb_Inss_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularINSS(_atualizarLista);
            _atualizarLista = true;
        }
        private void cb_Irrf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Irrf.Enabled == true)
                calcularIRRF(false, false);
        }
        private void cb_DescSimplificadoChanged(object sender, EventArgs e)
        {
            calcularIRRF(cb_DescSim.Checked, false);
            cb_Irrf.Enabled = false;
        }
        private void calcularIRRF(bool descontoSimplificado, bool atualizar)
        {
            TabelaProgressiva impostoRenda = new TabelaProgressiva(cb_Irrf.Text, double.Parse(txb_Depen.Text));

            cb_DescSim.Enabled = true;

            calcularTotalRendimentos();

            if (descontoSimplificado == false)
            {
                double rendimentosNaoTributaveis = _descPensao + folha.valorSalarioFamilia;
                _descDependente = impostoRenda.getValorDepentes();

                _baseCalculoIR = (_totalRendimentos - ((int.Parse(txb_Depen.Text) * _descDependente) - (-1 * _descInss) - (-1 * rendimentosNaoTributaveis)));

                _descImpostoRenda = impostoRenda.calcularDesconto("IRRF", _totalRendimentos, _baseCalculoIR);

            }
            else if (descontoSimplificado == true)
            {
                _baseCalculoIR = (_totalRendimentos - impostoRenda.calcularDescSimplificado());

                _descImpostoRenda = impostoRenda.calcularDesconto("IRRF", _totalRendimentos, _baseCalculoIR);
            }
            if (atualizar == false)
            {
                //Preencher os itens do listView
                if (descontoSimplificado == true)
                {
                    ListViewItem item = new ListViewItem("I.R.R.F SIMPLIFICADO");
                    item.SubItems.Add(impostoRenda.percentual.ToString("0.00") + "%");
                    item.SubItems.Add("");
                    item.SubItems.Add(_descImpostoRenda.ToString());
                    this.lsv_Lancamentos.Items.Add(item);
                    DeleteItemListView("I.R.R.F");
                }
                else
                {
                    ListViewItem item = new ListViewItem("I.R.R.F");
                    item.SubItems.Add(impostoRenda.percentual.ToString("0.00") + "%");
                    item.SubItems.Add("");
                    item.SubItems.Add(_descImpostoRenda.ToString());
                    this.lsv_Lancamentos.Items.Add(item);
                    DeleteItemListView("I.R.R.F SIMPLIFICADO");
                }
            }
            else
            {
                // Verificar se existe uma linha I.R.R.F no listView e atualiza os valores
                foreach (ColumnHeader coluna in lsv_Lancamentos.Columns)
                {
                    foreach (ListViewItem item in lsv_Lancamentos.Items)
                    {
                        if (item.SubItems[coluna.Index].Text == "I.R.R.F")
                        {
                            item.SubItems[1].Text = impostoRenda.percentual.ToString("0.00") + "%";
                            item.SubItems[3].Text = _descImpostoRenda.ToString();
                        }
                        else if (item.SubItems[coluna.Index].Text == "I.R.R.F SIMPLIFICADO")
                        {
                            item.SubItems[1].Text = impostoRenda.percentual.ToString("0.00") + "%";
                            item.SubItems[3].Text = _descImpostoRenda.ToString();
                        }
                    }
                }
            }
            cb_Irrf.Enabled = false;
            cb_Deducao.Enabled = true;
            cb_Remun.Enabled = true;

            txb_BaseCalIrrf.Text = _baseCalculoIR.ToString("0.00");
            txb_Irrf.Text = impostoRenda.percentual.ToString("0.00") + "%";
            calcularTotalDescontos();
            calcularSalarioLiquido();
        }
        private void DeleteItemListView(string nomeColuna)
        {
            foreach (ColumnHeader coluna in lsv_Lancamentos.Columns)
            {
                foreach (ListViewItem item in lsv_Lancamentos.Items)
                {
                    if (item.SubItems[coluna.Index].Text == nomeColuna)
                    {
                        item.Remove();
                    }
                }
            }
        }
        private void calcularINSS(bool atualizar)
        {
            TabelaProgressiva inss = new TabelaProgressiva(cb_Inss.Text);

            calcularTotalRendimentos();

            _descInss = inss.calcularDesconto("INSS", _totalRendimentos - folha.valorSalarioFamilia, _baseCalculoIR);

            if (atualizar == false)
            {
                //Preencher os itens do listView
                ListViewItem item = new ListViewItem("I.N.S.S");
                item.SubItems.Add(inss.percentual.ToString("0.00") + "%");
                item.SubItems.Add("");
                item.SubItems.Add(_descInss.ToString());
                this.lsv_Lancamentos.Items.Add(item);
            }
            else
            {
                // Verificar se existe uma linha I.N.S.S no listView e atualiza os valores
                foreach (ColumnHeader coluna in lsv_Lancamentos.Columns)
                {
                    foreach (ListViewItem item in lsv_Lancamentos.Items)
                    {
                        if (item.SubItems[coluna.Index].Text == "I.N.S.S")
                        {
                            item.SubItems[1].Text = inss.percentual.ToString("0.00") + "%";
                            item.SubItems[3].Text = _descInss.ToString();
                        }
                    }
                }
            }

            txb_BaseCalInss.Text = (_totalRendimentos - folha.valorSalarioFamilia).ToString("0.00");

            calcularTotalDescontos();
            calcularSalarioLiquido();
            cb_Irrf.Enabled = true;
            cb_Inss.Enabled = false;

        }
        private void CalcularFGTS()
        {
            folha.calcularFolha("fgts", _salario, lsv_Lancamentos);
            txb_Fgts.Text = (folha.valorFgts).ToString("0.00");
            txb_BaseCalFgts.Text = folha.salario_Bruto.ToString("0.00");
        }
        private void calcularSalarioLiquido()
        {
            _salarioLiquido = _totalRendimentos - _totalDescontos;
            txb_SalarioLiquid.Text = _salarioLiquido.ToString("0.00");
        }
        private void calcularTotalRendimentos()
        {
            _totalRendimentos = 0;
            double valorNumerico = 0;
            foreach (ListViewItem item in lsv_Lancamentos.Items)
            {
                if (double.TryParse(item.SubItems[2].Text, out valorNumerico))
                {
                    _totalRendimentos += valorNumerico;
                }
            }
            txb_Totalvencimentos.Text = _totalRendimentos.ToString("0.00");
            folha.salario_Bruto = _totalRendimentos;
        }
        private void calcularTotalDescontos()
        {
            _totalDescontos = 0;
            foreach (ListViewItem item in lsv_Lancamentos.Items)
            {
                string valorColuna = item.SubItems[3].Text;
                double valorNumerico;
                if (double.TryParse(valorColuna, out valorNumerico))
                {
                    _totalDescontos += valorNumerico;
                }
            }
            txb_Totaldescontos.Text = _totalDescontos.ToString("0.00");
        }
        private void atualizarListView()
        {
            if (_atualizarLista == true)
            {
                calcularINSS(_atualizarLista);
                calcularIRRF(false, _atualizarLista);
            }

            CalcularFGTS();
            calcularTotalDescontos();
            calcularTotalRendimentos();
            calcularSalarioLiquido();
        }
        private void frm_FolhaPagamento_Load(object sender, EventArgs e)
        {
            listaTextBoxes.Add(txb_Mat);
            listaTextBoxes.Add(txb_Nome);
            listaTextBoxes.Add(txb_Cargo);
            listaTextBoxes.Add(txb_Admissao);
            listaTextBoxes.Add(txb_Depart);
            listaTextBoxes.Add(txb_Salario);
            listaTextBoxes.Add(txb_Depen);
            listaTextBoxes.Add(txb_CargaHora);
            listaTextBoxes.Add(txb_Banco);
            listaTextBoxes.Add(txb_Agencia);
            listaTextBoxes.Add(txb_Conta);
            listaTextBoxes.Add(txb_Id);
            listaTextBoxes.Add(txb_Razao);
            listaTextBoxes.Add(txb_Cnpj);

            frm_Listagem listaFuncionario = new frm_Listagem("funcionario", listaTextBoxes);

            if (listaFuncionario.abrirjanela)
            {
                abrirJanela(listaFuncionario);
                if (listaFuncionario.flagliberarPanels)
                {
                    pnl_DadosEmp.Visible = true;
                    pnl_DadosFunc.Visible = true;
                    pnl_Lancamentos.Visible = true;
                    pnl_val_lancados.Visible = true;
                    lbl_valores.Visible = true;
                    btn_Limpar.Visible = true;
                    btn_enviar.Visible = true;
                    btn_Exit.Visible = true;

                    _salario = double.Parse(txb_Salario.Text);

                    //Preencher os itens do listView
                    ListViewItem item = new ListViewItem("SALARIO");
                    item.SubItems.Add(txb_CargaHora.Text + "h");
                    item.SubItems.Add(_salario.ToString());
                    item.SubItems.Add("");
                    this.lsv_Lancamentos.Items.Add(item);

                    calcularTotalRendimentos();
                    calcularSalarioLiquido();
                    CalcularFGTS();
                    this.lsv_Lancamentos.CheckBoxes = true;
                }
                else if (!listaFuncionario.flagliberarPanels)
                {
                    this.Close();
                }

            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            bool flag = false;
            foreach (ListViewItem item in lsv_Lancamentos.Items)
            {
                if ((item.Checked) & item.Text != "SALARIO" & item.Text != "I.N.S.S" & item.Text != "I.R.R.F" & item.Text != "I.R.R.F SIMPLIFICADO")
                {
                    lsv_Lancamentos.Items.Remove(item);
                    flag = false;
                    //ao deletar o salario familia reseta o valor para 0
                    if (item.Text == "SALÁRIO FAMÍLIA")
                    {
                        folha.valorSalarioFamilia = 0;
                    }
                    atualizarListView();
                    break;
                }
                else if ((item.Checked) & (item.Text == "SALARIO" || item.Text == "I.N.S.S" || item.Text == "I.R.R.F" || item.Text == "I.R.R.F SIMPLIFICADO"))
                {
                    MessageBox.Show("Este item não pode ser apagado !");
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Nenhum item selecionado !");
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            String[] textos = new String[] {
                cb_tipofolha.Text,
                dtp_calendario.Text,
                txb_Razao.Text,
                txb_Cnpj.Text,
                txb_Nome.Text,
                txb_Mat.Text,
                txb_Cargo.Text,
                txb_Admissao.Text,
                txb_Depart.Text,
                txb_Irrf.Text,
                txb_BaseCalInss.Text,
                txb_Fgts.Text,
                txb_Totalvencimentos.Text,
                txb_Totaldescontos.Text,
                txb_SalarioLiquid.Text,
                txb_Banco.Text,
                txb_Agencia.Text,
                txb_Conta.Text,
                txb_BaseCalIrrf.Text,
                txb_BaseCalFgts.Text
            };
            EmitirFolhaPagamento emitirfolha = new EmitirFolhaPagamento(lsv_Lancamentos, textos);
        }
    }
}


