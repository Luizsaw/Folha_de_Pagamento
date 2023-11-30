using PrjFolhaPagamento.Entity.FollhaPagamento;
using RHS_Folha_de_Pagamento.Interface;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFolhaPagamento.Entity
{
    internal class FolhaPagamento
    {
      
        public double cargaHoraMensal { get; set; }
        public double horas_Trab{ get; private set; }
        public double percentualHE { get; private set; }
        public double salario_Liquido {get; private set;}
        public double salario_Bruto { get; set; }
        public double valorFgts { get; private set; }
        public double valorSalarioFamilia { get; set; }


        private ListViewItem _item;

        //dados:Darabase;
        //desconto_Inss:TabelaProgressiva;
        //desconto_Ir:TabelaProgressiva;
      
        //Construtores
        public FolhaPagamento()
        {
            
        }

       public void calcularFolha(string calculoTipo, double salario, ListView lancamentos)
        {
            FolhaValores valoresFolha = new FolhaValores();
            double valor = 0;
  
            switch(calculoTipo)
            {
                case "horasExtras":    
                    //Chamar form
                    frm_HoraExtras hextras = new frm_HoraExtras(); 
                    hextras.txb_salarioB = salario.ToString();
                    hextras.txb_cargaH = cargaHoraMensal.ToString();
                    hextras.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    this.horas_Trab = double.Parse(hextras.txb_quantH.Text);
                    this.percentualHE = double.Parse(hextras.txb_Percent.Text);

                    // Realizar o calculo
                    valor = horas_Trab * ((salario / cargaHoraMensal) + ((salario / cargaHoraMensal) * (percentualHE/100)));

                    ///Adicionar os valores na classe ValoresFolha
                    valoresFolha.tipo.Add("Remuneração");
                    valoresFolha.descricao.Add("HORAS EXTRAS ");
                    valoresFolha.referencia.Add(horas_Trab);
                    valoresFolha.valor.Add(valor);

                    //Alimentar os itens do listView
                    this._item = new ListViewItem(valoresFolha.descricao[0] + percentualHE +"%");
                    this._item.SubItems.Add(valoresFolha.referencia[0].ToString()+"h");
                    this._item.SubItems.Add(valoresFolha.valor[0].ToString("0.00"));
                    this._item.SubItems.Add("");
                    lancamentos.Items.Add(this._item);
                    break;
                case "valeTransporte":
                    //Chamar form
                    frm_ValeTransporte vt = new frm_ValeTransporte();
                    vt.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    int dias  = int.Parse(vt.txb_dias.Text);
                    double valordiario = double.Parse(vt.txb_valordiario.Text);

                    // Realizar o calculo
                    valor = dias * valordiario;

                    //verificar porcentagem de desconto
                    double limitePercentual = salario * 0.06; // Calcula 6% do salário
                    valor = (valor > limitePercentual) ? limitePercentual : valor;

                    //Adicionar os valores na classe ValoresFolha
                    valoresFolha.tipo.Add("Dedução");
                    valoresFolha.descricao.Add("VALE TRANSPORTE");
                    valoresFolha.referencia.Add(6.00);
                    valoresFolha.valor.Add(valor);
                    

                    //Alimentar os itens do listView
                    this._item = new ListViewItem(valoresFolha.descricao[0]);
                    this._item.SubItems.Add(valoresFolha.referencia[0].ToString()+"%");
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add(valoresFolha.valor[0].ToString("0.00"));
                    lancamentos.Items.Add(this._item);

                    break;
                case "fgts":

                    // Realizar o calculo
                    salario_Bruto -= valorSalarioFamilia;
                    valorFgts = (salario_Bruto * 0.08);

                    //Adicionar os valores na classe ValoresFolha
                    valoresFolha.tipo.Add("Remuneração");
                    valoresFolha.descricao.Add("FGTS");
                    valoresFolha.referencia.Add(8);
                    valoresFolha.valor.Add(valorFgts);
                    break;
                case "salarioFamilia":
                    //Chamar form
                    frm_SalarioFamilia salarioFamilia = new frm_SalarioFamilia();
                    salarioFamilia.set_RemunBase = salario.ToString("0.00");
                    salarioFamilia.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    double quantFilho = double.Parse(salarioFamilia.get_Numfilhos.Text);

                    // Realizar o calculo
                    if(double.Parse(salarioFamilia.get_RemunBase.Text) <= double.Parse(salarioFamilia.get_RemunMax.Text))
                    {
                        valorSalarioFamilia = double.Parse(salarioFamilia.get_ValorUnit.Text) * quantFilho;


                        //Adicionar os valores na classe ValoresFolha
                        valoresFolha.tipo.Add("Remuneração");
                        valoresFolha.descricao.Add("SALÁRIO FAMÍLIA");
                        valoresFolha.referencia.Add(double.Parse(salarioFamilia.get_Numfilhos.Text));
                        valoresFolha.valor.Add(valorSalarioFamilia);

                        //Alimentar os itens do listView
                        this._item = new ListViewItem(valoresFolha.descricao[0]);
                        this._item.SubItems.Add(valoresFolha.referencia[0].ToString());
                        this._item.SubItems.Add(valoresFolha.valor[0].ToString("0.00"));
                        this._item.SubItems.Add("");
                        lancamentos.Items.Add(this._item);
                    }
                    else
                    {
                        MessageBox.Show("Remuneração Base não entra na cota do Salário Família");
                    }
                    break;
                case "faltas":
                    //Chamar form
                    frm_Faltas faltas = new frm_Faltas();
                    faltas.set_RemunBase = salario.ToString("0.00");
                    faltas.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    double quantDias = double.Parse(faltas.get_Dias.Text);
                    double quantFaltas = double.Parse(faltas.get_Faltas.Text);

                    // Realizar o calculo

                    double descontoFalta = (salario_Bruto / quantDias) * quantFaltas;


                    //Alimentar os itens do listView
                    this._item = new ListViewItem("DESC. FALTAS");
                    this._item.SubItems.Add(faltas.get_Faltas.Text);
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add(descontoFalta.ToString("0.00"));
                    lancamentos.Items.Add(this._item);

                    break;
                case "atrasos":
                    //Chamar form
                    frm_Atrasos atrasos = new frm_Atrasos();
                    atrasos.set_RemunBase = salario.ToString("0.00");
                    atrasos.set_cargaHoraria = cargaHoraMensal.ToString();
                    atrasos.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    double quantHoras = double.Parse(atrasos.get_Atrasos.Text);

                    // Realizar o calculo

                    double descontoAtrasos = (salario_Bruto / cargaHoraMensal) * quantHoras;


                    //Alimentar os itens do listView
                    this._item = new ListViewItem("DESC. HORAS INJUSTIFICADAS");
                    this._item.SubItems.Add(atrasos.get_Atrasos.Text);
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add(descontoAtrasos.ToString("0.00"));
                    lancamentos.Items.Add(this._item);
                    break;
                case "planosaude":
                    //Chamar form
                    frm_PlanoSaude ps = new frm_PlanoSaude(salario);
                    ps.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    double valorPlano = double.Parse(ps.get_valor.Text);

                    //Alimentar os itens do listView
                    this._item = new ListViewItem("DESC. PLANO DE SAÚDE");
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add(valorPlano.ToString("0.00"));
                    lancamentos.Items.Add(this._item);
                    break;
                case "outrosded":
                    //Chamar form
                    frm_Outras outrasDeducoes = new frm_Outras();
                    outrasDeducoes.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    double outrosValores = double.Parse(outrasDeducoes.get_valor.Text);

                    //Alimentar os itens do listView
                    this._item = new ListViewItem(outrasDeducoes.get_descricao.Text.ToUpper());
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add(outrosValores.ToString("0.00"));
                    lancamentos.Items.Add(this._item);
                    break;
                case "outrosrem":
                    //Chamar form
                    frm_Outras outrasRemuneracoes = new frm_Outras();
                    outrasRemuneracoes.ShowDialog();

                    //Receber os dados do usuarios e converter para double
                    double outrosValoresRem = double.Parse(outrasRemuneracoes.get_valor.Text);

                    //Alimentar os itens do listView
                    this._item = new ListViewItem(outrasRemuneracoes.get_descricao.Text.ToUpper());
                    this._item.SubItems.Add("");
                    this._item.SubItems.Add(outrosValoresRem.ToString("0.00"));
                    this._item.SubItems.Add("");
                    lancamentos.Items.Add(this._item);
                    break;
                case "adicionais":
                    //Chamar form
                    frm_Adicionais adicionais = new frm_Adicionais();
                    adicionais.set_RemunBase = salario.ToString("0.00");
                    adicionais.set_cargaHoraria = cargaHoraMensal.ToString();
                    adicionais.ShowDialog();

                    double valorInsalubre = 0;
                    double valorNoturno = 0;

                    //calculo insalubridade

                    if (adicionais.get_valor.Text != string.Empty)
                    {
                        valorInsalubre = salario * ((double.Parse(adicionais.get_valor.Text) / 100));
                    }
                      
                    if(valorInsalubre > 0)
                    {
                        //Alimentar os itens do listView
                        this._item = new ListViewItem("INSALUBRIDADE " + adicionais.get_valor.Text + "%");
                        this._item.SubItems.Add(adicionais.get_valor.Text + "%");
                        this._item.SubItems.Add(valorInsalubre.ToString("0.00"));
                        this._item.SubItems.Add("");
                        lancamentos.Items.Add(this._item);
                    }

                    //calculo adicional noturno
                    if ((adicionais.get_cargaHoraria.Text != string.Empty) &&
                        (adicionais.get_horas.Text != string.Empty) &&
                        (adicionais.get_percentual.Text != string.Empty) &&
                        (adicionais.get_horas.Text != string.Empty))
                    {
                        this.horas_Trab = double.Parse(adicionais.get_cargaHoraria.Text);
                        this.percentualHE = double.Parse(adicionais.get_percentual.Text);

                        valorNoturno = ((((salario / horas_Trab) * (percentualHE / 100)) + (salario / horas_Trab)) * double.Parse(adicionais.get_horas.Text));
                    }

                    if (valorNoturno > 0)
                    {
                        //Alimentar os itens do listView
                        this._item = new ListViewItem("ADICIONAL. NOTURNO " + percentualHE + "%");
                        this._item.SubItems.Add(adicionais.get_horas.Text + "h");
                        this._item.SubItems.Add(valorNoturno.ToString("0.00"));
                        this._item.SubItems.Add("");
                        lancamentos.Items.Add(this._item);
                    }
                   
                    break;
            }
        }
        
   
    }
}
