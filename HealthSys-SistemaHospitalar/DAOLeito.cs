using MySql.Data.MySqlClient;//Importando a estrutura de conexão com o banco de dados
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthSys_SistemaHospitalar
{
    internal class DAOLeito
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public int i;
        public int contar;
        public string msg;
        public int[] codigo;
        public int[] numero;
        public string[] setor;
        public string[] statusLeito;

        public DAOLeito()
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

        public void InserirLeito(int numero, string setor, string statusLeito)
        {
            try
            {
                this.dados = $"('', '{numero}', '{setor}', '{statusLeito}')";
                this.comando = $"Insert into leito(codigo, numero, setor, statusLeito) values{this.dados}";
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
            this.numero = new int[100];
            this.setor = new string[100];
            this.statusLeito = new string[100];

            //Preencher os vetores com valores padrões
            for (i = 0; i < 100; i++)
            {
                this.codigo[i] = 0;
                this.numero[i] = 0;
                this.setor[i] = "";
                this.statusLeito[i] = "";

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
                this.numero[i] = Convert.ToInt32(leitura["numero"] + "");
                this.setor[i] = leitura["setor"] + "";
                this.statusLeito[i] = leitura["statusLeito"] + "";

                i++;
                this.contar++;//Informar quantos dados tem no banco
            }//Fim do while
        }//Fim do PreencherVetor

        public string AtualizarLeito(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update leito set {campo} = '{novoDado}' where codigo = '{codigo}'";
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
                string query = $"delete from leito where codigo = '{codigo}'";
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

    }//Fim da classe
}//Fim do projeto



