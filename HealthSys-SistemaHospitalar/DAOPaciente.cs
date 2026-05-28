using MySql.Data.MySqlClient;//Importando a estrutura de conexão com o banco de dados
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HealthSys_SistemaHospitalar
{
    class DAOPaciente
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public int i;
        public int contar;
        public string msg;
        public int[] codigo;
        public string[] nome;
        public long[] CPF;
        public DateTime[] dataNascimento;
        public string[] tipoSanguineo;
        public string[] telefone;
        public string[] endereco;
        public string[] convenio;

        public DAOPaciente()
        {
            conexao = new MySqlConnection("server=localhost;port=3307;DataBase=HealthSys;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//Abrindo a conexão
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show($"Algo deu errado!\n\n {erro}");
                conexao.Close();//Fecha conexão com o banco de dados
            }//Fim do método try_catch
        }

        public void InserirPaciente(string nome , long CPF, DateTime dataNascimento, string tipoSanguineo, string telefone, string endereco, string convenio)
        {
            try
            {
                string dataNascimentoFT = dataNascimento.ToString("yyyy-MM-dd");
                this.dados = $"('', '{nome}', '{CPF}', '{dataNascimento}', '{tipoSanguineo}', '{telefone}', '{endereco}', '{convenio}')";
                this.comando = $"Insert into paciente(codigo, nome, CPF, dataNascimento, tipoSanguineo, telefone, endereco, convenio) values{this.dados}";
                //Inserir comando
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show($"Inserido com Sucesso! \n\n{resultado}");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado\n\n {erro}");
            }//Fim do método try_catch
        }//Fim do InserirPaciente

        public void PreencherVetor()
        {
            string query = "select * from paciente";//Buscando todos os dados da tabela autor
                                                    //Instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.CPF = new long[100];
            this.dataNascimento = new DateTime[100];
            this.tipoSanguineo = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];
            this.convenio = new string[100];

            //Preencher os vetores com valores padrões
            for (i = 0; i < 100; i++)
            {
                this.codigo[i] = 0;
                this.nome[i] = "";
                this.CPF[i] = 0;
                this.dataNascimento[i] = DateTime.MinValue;
                this.tipoSanguineo[i] = "";
                this.telefone[i] = "";
                this.endereco[i] = "";
                this.convenio[i] = "";

            }//fim do for


            //Executar o comando do SQL
            MySqlCommand coletar = new MySqlCommand(query, this.conexao);

            //Leitura do dado no banco
            MySqlDataReader leitura = coletar.ExecuteReader();//Percorre o banco e traz os dados

            //Zerar o contador
            i = 0;
            this.contar = 0;
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.nome[i] = leitura["nome"] + "";
                this.CPF[i] = Convert.ToInt64(leitura["CPF"] + "");
                this.dataNascimento[i] = Convert.ToDateTime(leitura["dataNascimento"] + "");
                this.tipoSanguineo[i] = leitura["tipoSanguineo"] + "";
                this.telefone[i] = leitura["telefone"] + "";
                this.endereco[i] = leitura["endereco"] + "";
                this.convenio[i] = leitura["convenio"] + "";
                i++;
                this.contar++;//Informar quantos dados tem no banco
            }//Fim do while
        }//Fim do PreencherVetor

        public string AtualizarPaciente(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update paciente set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //executar o comando

                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Comando da inserção no banco
                return $"Atualizado com sucesso!\n\n{resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n{erro}";
            }//Fim do método try_catch
        }//Fim do AtualizarPaciente

        public string Deletar(int codigo)
        {
            try
            {
                string query = $"delete from paciente where codigo = '{codigo}'";
                //executar o comando

                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//comando da inserção no banco
                return $"Deletado com sucesso!\n\n{resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n{erro}";
            }//Fim do método try_catch
        }//Fim do Deletar

        public bool ValidarLoginPaciente(string nome, string CPF)
        {
            string sql = "SELECT * FROM paciente " +
                         "WHERE nome = '" + nome + "' AND CPF = '" + CPF + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader leitura = cmd.ExecuteReader();

            bool encontrou = leitura.Read();
            leitura.Close();
            return encontrou;
        }

    }//Fim da classe
}//Fim do projeto

