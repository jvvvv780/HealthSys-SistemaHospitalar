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
    internal class DAOExame
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;

        public DAOExame()
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

        public void InserirExame(string descricao, DateTime dataExame, string resultadoExame)
        {
            try
            {
                this.dados = $"('', '{descricao}', '{dataExame}', '{resultadoExame}')";
                this.comando = $"Insert into exame(codigo, descricao, dataExame, resultadoExame) values{this.dados}";
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

        public string AtualizarExame(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update exame set {campo} = '{novoDado}' where codigo = '{codigo}'";
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
                string query = $"delete from exame where codigo = '{codigo}'";
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



