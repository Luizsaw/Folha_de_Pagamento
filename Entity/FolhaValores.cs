using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjFolhaPagamento;
using PrjFolhaPagamento.Entity.BancodeDados;

namespace PrjFolhaPagamento.Entity.FollhaPagamento
{
    internal class FolhaValores
    {
        //atributos
        private List<int> _id_Valor;
        private List<string> _tipo;
        private List<string> _descricao;
        private List<double> _referencia;
        private List<double> _valor;
        private List<int> _id_Folha;

        public List<int> id_Valor
        {
            get { return _id_Valor; }
            set { _id_Valor = value; }
        }
        public List<string> tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public List<string> descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public List<double> referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }
        public List<double> valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public List<int> id_Folha
        {
            get { return _id_Folha; }
            set { _id_Folha = value; }
        }

        public FolhaValores()
        {
            this._tipo = new List<string>();
            this.referencia = new List<double>();
            this._descricao = new List<string>();
            this._valor = new List<double>();
        }

        // metodos
       
        public void cadastrarValor()
        {

        }
        public void removerValor ()
        {

        }
        public void listarValor()
        {
        }
        public void buscarValor(string cod)
        {

        }
       

    }
}
