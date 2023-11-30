using PrjFolhaPagamento.Entity.BancodeDados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFolhaPagamento.Entity
{
    internal class TabelaProgressiva
    {
        //atributos
        private string _ano;
        public double percentual { get; private set; }
        public double valorDepentes { get; private set; }

        public TabelaProgressiva()
        {
            
        }
        public TabelaProgressiva(string ano)
        {
            this._ano = ano;
        }

        public TabelaProgressiva(string ano, double valorDepentes)
        {
            this._ano = ano;
            this.valorDepentes = valorDepentes;
        }
        //metodos

        //adicionando tabela INSS
        public void addTabela(double faixaMin, double faixaMax, double alicota)
        { 
        
        }
        //adicionando tabela IRRF
        public void addTabela(double faixaMin, double faixaMax, double alicota, double valDepedentes)
        {

        }
        public void editarTabela() 
        {
        
        }
        public void excluirTabela()
        {

        }
        public void listarTabela()
        {

        }
        public double getValorDepentes()
        {
            BancoDados bancoDados = new BancoDados();
            string query = "SELECT Valor FROM \"RHS\".\"tb_valor_dependente\" WHERE mes_ano_vigente = " + "'" + _ano + "'";
            return valorDepentes = double.Parse(bancoDados.ObterValor(query));
        }
        public double calcularDescSimplificado()
        {
            BancoDados bancoDados = new BancoDados();
            double descontoSimplificado;
            string query = "SELECT faixa_monetaria_max FROM \"RHS\".\"tb_tab_progressiva\" WHERE mes_ano_vigente = " + "'" + _ano + "'" + " and aliquota = 0";

            return descontoSimplificado = (double.Parse(bancoDados.ObterValor(query))*0.25);
        }
        public double calcularDesconto(string tabelaNome, double _totalRendimentos, double baseCalculoIR)
        {
            double valorDesconto = 0;
            string[,] valores;
            string nomeTabela = "\"RHS\".\"tb_tab_progressiva\"";
            List<string> nomeColunas = new List<string>();
            BancoDados bancoDados = new BancoDados();

            nomeColunas.Add("tipo");
            nomeColunas.Add("mes_ano_vigente");
            nomeColunas.Add("faixa_monetaria_min");
            nomeColunas.Add("faixa_monetaria_max");
            nomeColunas.Add("aliquota");
            nomeColunas.Add("deducao");

            valores = bancoDados.ObterValoresDaTabelaProgressiva(tabelaNome, _ano, nomeColunas, nomeTabela);

            if (tabelaNome == "INSS")
            {
                if (_totalRendimentos <= double.Parse(valores[0,3])) //Faixa salarial 1
                {
                    valorDesconto = (_totalRendimentos * double.Parse(valores[0, 4]));
                    percentual = (double.Parse(valores[0, 4]) * 100);
                }
                else if (_totalRendimentos <= double.Parse(valores[1, 3])) //Faixa salarial 2
                {
                    valorDesconto = (_totalRendimentos * double.Parse(valores[1, 4]));
                    valorDesconto -= double.Parse(valores[1, 5]);
                    percentual = (double.Parse(valores[1, 4]) * 100);
                }
                else if (_totalRendimentos <= double.Parse(valores[2, 3])) //Faixa salarial 3
                {
                    valorDesconto = (_totalRendimentos * double.Parse(valores[2, 4]));
                    valorDesconto -= double.Parse(valores[2, 5]);
                    percentual = (double.Parse(valores[2, 4]) * 100);
                }
                else if (_totalRendimentos <= double.Parse(valores[3, 3])) //Faixa salarial 4
                {
                    valorDesconto = (_totalRendimentos * double.Parse(valores[3, 4]));
                    valorDesconto -= double.Parse(valores[3, 5]);
                    percentual = (double.Parse(valores[3, 4]) * 100);
                }
                else //Teto
                {
                    
                    valorDesconto = (double.Parse(valores[0, 3]) * double.Parse(valores[0, 4]));
                    

                    valorDesconto += ((double.Parse(valores[1, 3]) - double.Parse(valores[0, 3])) * double.Parse(valores[1, 4]));
                    

                    valorDesconto += ((double.Parse(valores[2, 3]) - double.Parse(valores[1, 3])) *  double.Parse(valores[2, 4]));
                    

                    valorDesconto += ((double.Parse(valores[3, 3]) - double.Parse(valores[2, 3])) * double.Parse(valores[3, 4]));

                    valorDesconto = Math.Round(valorDesconto, 2);

                    percentual = (valorDesconto * 100) / _totalRendimentos;
                }
                
            }
            else if (tabelaNome == "IRRF")
            {

                if (baseCalculoIR <= double.Parse(valores[0, 3])) //Faixa 1
                {
                    valorDesconto = (baseCalculoIR * double.Parse(valores[0, 4]));
                    percentual = (double.Parse(valores[0, 4]) * 100);
                }
                else if (baseCalculoIR <= double.Parse(valores[1, 3])) //Faixa 2
                {
                    valorDesconto = (baseCalculoIR * double.Parse(valores[1, 4]));
                    valorDesconto -= double.Parse(valores[1, 5]);
                    percentual = (double.Parse(valores[1, 4]) * 100);
                }
                else if (baseCalculoIR <= double.Parse(valores[2, 3])) //Faixa 3
                {
                    valorDesconto = (baseCalculoIR * double.Parse(valores[2, 4]));
                    valorDesconto -= double.Parse(valores[2, 5]);
                    percentual = (double.Parse(valores[2, 4]) * 100);
                }
                else if (baseCalculoIR <= double.Parse(valores[3, 3])) //Faixa 4
                {
                    valorDesconto = (baseCalculoIR * double.Parse(valores[3, 4]));
                    valorDesconto -= double.Parse(valores[3, 5]);
                    percentual = (double.Parse(valores[3, 4]) * 100);
                }
                else //Faixa 5
                {
                    valorDesconto = (baseCalculoIR * double.Parse(valores[4, 4]));
                    valorDesconto -= double.Parse(valores[4, 5]);
                    percentual = (double.Parse(valores[4, 4]) * 100);
                }
            }
            valorDesconto = Math.Round(valorDesconto, 2);
            return valorDesconto;
        }
    }
}
