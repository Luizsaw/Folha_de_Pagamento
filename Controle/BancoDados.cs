 using Microsoft.VisualBasic;
using PrjFolhaPagamento.Entity.FollhaPagamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Reflection;
using System.Globalization;
using NpgsqlTypes;
using System.Security.Cryptography;

namespace PrjFolhaPagamento.Entity.BancodeDados
{
    internal class BancoDados
    {
        private static string servidor = "berry.db.elephantsql.com";
        private static string bancoDados = "kwlriltm";
        private static string usuario = "kwlriltm";
        private static string senha = "XSvdSkoe1d8aCwESg7DQsJ7ay6ADyEz5";
        private static string porta = "5432";
        private NpgsqlConnection conexao;
        public bool estarConectado { get; set; }
        public static string StrConexao
        {
            // String de conexao
            get { return $"Host={servidor};Port={porta};Database={bancoDados};User Id={usuario};Password={senha};"; }

        }
        public BancoDados()
        {
            
        }
        public void Conectar()
        {
            try
            {
               conexao = new NpgsqlConnection(StrConexao);
               conexao.Open();
                estarConectado = true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Falha na comunicação com o banco de dados...\n\n"+ e.Message);
                estarConectado = false;
            }            
        }
        public void Desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        public DataTable Consultar(string sqlQuery)
        {
            DataTable dataTable = new DataTable();

            try
            {
                Conectar();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, conexao))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }     
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataTable;
        }
        //Funcao que deleta um registro de uma tabela, SEM CHAVES ESTRANGEIRAS, usando o id
        public bool DeletarRegistro(string nomeTabela, string nomeColuna, int id)
        {
            Conectar();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.Connection = conexao;

                // Substitua 'sua_tabela' pelo nome da sua tabela
                command.CommandText = "DELETE FROM " + nomeTabela + " WHERE "+nomeColuna+" = @id";
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Desconectar();
                        return true;
                    }
                    else
                    {
                        Desconectar();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar o registro: " + ex.Message);
                    Desconectar();
                    return false;
                }
            }

        }
        public bool DeletarRegistro(string nomeTabela, string nomeColuna, string id)
        {
            Conectar();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.Connection = conexao;

                // Substitua 'sua_tabela' pelo nome da sua tabela
                command.CommandText = "DELETE FROM " + nomeTabela + " WHERE " + nomeColuna + " = @id";
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Desconectar();
                        return true;
                    }
                    else
                    {
                        Desconectar();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar o registro: " + ex.Message);
                    Desconectar();
                    return false;
                }
            }
        }
        //Função que executa uma query e preenche os valores de uma coluna em um comboBox
        public void PreencherComboBox(string query,string coluna, ComboBox comboBox)
        {
            try
            {
                Conectar();
                NpgsqlCommand command = new NpgsqlCommand(query, conexao);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader[coluna].ToString();
                    comboBox.Items.Add(nome);
                }
                reader.Close();

                //verificar e remove itens repitidos no comboBox
                for (int i = 0; i < comboBox.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j < comboBox.Items.Count; j++)
                    {
                        if (comboBox.Items[i].ToString() == comboBox.Items[j].ToString())
                        {
                            comboBox.Items.RemoveAt(j);
                        }
                    }
                }
                Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher ComboBox: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        //Função que executa uma query e retorna apenas um valor string de uma consulta
        public string ObterValor(string query)
        {
            DataTable dataTable = new DataTable();
            Conectar();
            using (NpgsqlCommand command = new NpgsqlCommand(query, conexao))
            {
                // Executa a consulta e obtém o resultado
                object resultado = command.ExecuteScalar();
                Desconectar();
                return resultado.ToString();
            }
        }
        //Função que executa uma query e retorna os valores de colunas de uma tabela em uma matriz bidimensional    
        public string[,] ObterValoresDaTabelaProgressiva(string tipo, string ano,List<string> nomeColuna, string nomeTabela)
        {
            string query = "SELECT " 
                            + nomeColuna[0] + ","
                            + nomeColuna[1] + "," 
                            + nomeColuna[2] + ","
                            + nomeColuna[3] + ","
                            + nomeColuna[4] + ","
                            + nomeColuna[5] + 
                           " FROM " 
                           + nomeTabela +
                           " WHERE "
                           + nomeColuna[0] + " = " + "'"+ tipo +"'" + // Tipo: INSS ou IRRF
                           " AND "
                           + nomeColuna[1] + " = " + "'" + ano + "'"; 

            DataTable dataTable = new DataTable();

            Conectar();
                using (NpgsqlCommand command = new NpgsqlCommand(query, conexao))
                {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
            int numLinhas = dataTable.Rows.Count;
            int numColunas = dataTable.Columns.Count;
            string[,] valores = new string[numLinhas, numColunas];

            for (int i = 0; i < numLinhas; i++)
            {
                valores[i, 0] = dataTable.Rows[i][nomeColuna[0]].ToString();
                valores[i, 1] = dataTable.Rows[i][nomeColuna[1]].ToString();
                valores[i, 2] = dataTable.Rows[i][nomeColuna[2]].ToString();
                valores[i, 3] = dataTable.Rows[i][nomeColuna[3]].ToString();
                valores[i, 4] = dataTable.Rows[i][nomeColuna[4]].ToString();
                valores[i, 5] = dataTable.Rows[i][nomeColuna[5]].ToString();
            }
            Desconectar();
            return valores;
            
        }
        //Função que executa uma query e retorna valores em um listview
        public void ExecutarQueryListView(string query, ListView lista, List <string> nomeColunas)
        {
            lista.Items.Clear();
            try
            {
                Conectar();
                using (NpgsqlCommand command = new NpgsqlCommand(query, conexao))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(row[nomeColunas[0]].ToString());
                            for (int i = 1; i < nomeColunas.Count; i++)
                            {
                                item.SubItems.Add(row[nomeColunas[i]].ToString());
                            }
                            lista.Items.Add(item);
                        }

                        // identificar o tipo de data em uma coluna do ListView e alterar o formato de exibição
                        foreach (ColumnHeader coluna in lista.Columns)
                        {
                            bool colunaData = true; // Indica se a coluna é do tipo data

                            // Verificar os valores dos subitens da coluna
                            foreach (ListViewItem item in lista.Items)
                            {
                                if (!DateTime.TryParse(item.SubItems[coluna.Index].Text, out _))
                                {
                                    colunaData = false;
                                    break;
                                }
                            }

                            if (colunaData)
                            {
                                // A coluna é do tipo data
                                // Atualizar o formato de exibição dos subitens da coluna
                                foreach (ListViewItem item in lista.Items)
                                {
                                    DateTime data = DateTime.Parse(item.SubItems[coluna.Index].Text);
                                    item.SubItems[coluna.Index].Text = data.ToString("dd/MM/yyyy"); //formato desejado
                                }
                            }
                        }
                    }
                }
                //Desconectar();
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show("Erro durante a conexão: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        /*A função InserirDados recebe o nome da tabela, um array com os nomes das colunas e um array com os valores correspondentes para cada coluna. Ela monta a query de inserção dinamicamente, substituindo os nomes das colunas e os valores pelos parâmetros adequados.*/
        public void InserirDados(string tabelaNomes, string[] colunaNomes, object[] valores)
        {
            // Verifique se os arrays têm o mesmo comprimento
            if (colunaNomes.Length != valores.Length)
            {
                throw new ArgumentException("O número de colunas e valores deve ser o mesmo.");
            }

            Conectar();

            // Use StringBuilder para construir a string de parâmetros
            StringBuilder parametros = new StringBuilder();
            for (int i = 0; i < colunaNomes.Length; i++)
            {
                parametros.Append($"@param{i}, ");
            }
            parametros.Length -= 2;  // Remover a vírgula final

            string query = $"INSERT INTO {tabelaNomes} ({string.Join(", ", colunaNomes)}) VALUES ({parametros})";

            using (NpgsqlCommand command = new NpgsqlCommand(query, conexao))
            {
                // Adicionar parâmetros com tipos específicos
                for (int i = 0; i < colunaNomes.Length; i++)
                {
                    // Ajuste o tipo de dado conforme necessário
                    command.Parameters.AddWithValue($"@param{i}", valores[i]);
                }

                command.ExecuteNonQuery();
            }

            Desconectar();
        }
        // Método para obter o tipo de dado NpgsqlDbType com base no tipo do valor
        public void InserirFolhaPagamento(string caminhoArquivo, int id_funcionario, string dataemissao)
        {
            try
            {
                byte[] dadosArquivo = System.IO.File.ReadAllBytes(caminhoArquivo);
                Conectar();
                string query = "INSERT INTO \"RHS\".\"tb_folha_pagamento\" (id_funcionario,  nome_arquivo, data_emissao, arquivo) VALUES (@id_funcionario, @nome_arquivo, @data_emissao, @arquivo)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);
                    cmd.Parameters.AddWithValue("@nome_arquivo", Path.GetFileName(caminhoArquivo)); 
                    cmd.Parameters.AddWithValue("@data_emissao", dataemissao);
                    cmd.Parameters.Add(new NpgsqlParameter("@arquivo", NpgsqlDbType.Bytea) { Value = dadosArquivo });

                    cmd.ExecuteNonQuery();
                }
                Desconectar();
                MessageBox.Show("Arquivo salvo no banco de dados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir arquivo no banco de dados: " + ex.Message);
            }
        }
        public string buscarCredenciaisUser(string user, string senha)
        {
            try
            {
                Conectar();

                string consulta = "SELECT * FROM \"RHS\".\"tb_usuario\" WHERE login = @login";
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexao))
                {
                    comando.Parameters.AddWithValue("@login", user);

                    using (NpgsqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Avança para a próxima linha

                            int senhaIndex = reader.GetOrdinal("senha");
                            string senhaHashArmazenado = reader.GetString(senhaIndex);

                            // Calcula o hash da senha fornecida
                            string senhaHashFornecido = CalcularHashSenha(senha);

                            // Comparação direta dos hashes
                            if (senhaHashFornecido == senhaHashArmazenado)
                            {
                                int tipoIndex = reader.GetOrdinal("login");
                                string login = reader.GetString(tipoIndex);

                                // Usuário autenticado com sucesso
                                return login;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de autenticação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }

            // Usuário não autenticado
            return "U.N.A";
        }
       // Método para calcular o hash da senha usando SHA256
        private string CalcularHashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public int retornarIdEmpresa(string nomeTabela, string nomeColuna, string valorColuna)
        {
            int id = -1;

            Conectar();

                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conexao;

                    // Consulta para obter o ID usando o nome da coluna
                    command.CommandText = $"SELECT id FROM {nomeTabela} WHERE {nomeColuna} = @valorColuna";
                    command.Parameters.AddWithValue("@valorColuna", valorColuna);

                    // Executa a consulta e obtém o ID
                    object resultado = command.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        id = Convert.ToInt32(resultado);
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado para o valor especificado na coluna.");
                    }
                }
            Desconectar();

            return id;
        }
        public void exibirRegistroPonto(string query, ListView lista, List<string> nomeColunas)
        {
            lista.Items.Clear();
            try
            {
                Conectar();
                using (NpgsqlCommand command = new NpgsqlCommand(query, conexao))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(row[nomeColunas[0]].ToString());
                            for (int i = 1; i < nomeColunas.Count; i++)
                            {
                                item.SubItems.Add(row[nomeColunas[i]].ToString());
                            }
                            lista.Items.Add(item);
                        }
                    }
                }
                //Desconectar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro durante a conexão: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
