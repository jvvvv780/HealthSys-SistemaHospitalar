using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthSys_SistemaHospitalar
{
    public partial class Consultar_Paciente : Form
    {
        DAOPaciente paciente;

        public Consultar_Paciente()
        {
            InitializeComponent();
            this.paciente = new DAOPaciente();
            ChamarMetodo(dataGridView1);//Configurar toda a estrutura
        }

        private void Consultar_Paciente_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ChamarMetodo(DataGridView datagrid)
        {

            ConfigurarDataGrid(datagrid);//Configuro a estrutura
            NomeColunas(datagrid);//Configuro os nomes
            AdicionarDados(datagrid);//Adiciono os dados
        }//fim do método

        public void NomeColunas(DataGridView dataGrid)
        {
            if (dataGrid.Columns.Count >= 8)
            {
                dataGrid.Columns[0].Name = "Código";
                dataGrid.Columns[1].Name = "Nome";
                dataGrid.Columns[2].Name = "CPF";
                dataGrid.Columns[3].Name = "Data de Nascimento";
                dataGrid.Columns[4].Name = "Tipo Sanguíneo";
                dataGrid.Columns[5].Name = "Telefone";
                dataGrid.Columns[6].Name = "Endereço";
                dataGrid.Columns[7].Name = "Convênio";
            }

            
            }//fim do método

        //Definir a estrutura da tabela
        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false;//Não permito que o usuário adicione linhas
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;

            dataGrid.ColumnCount = 8;
        }//fim do configurar

        public void AdicionarDados(DataGridView dataGrid)
        {
            //Primeira coisa será: PREENCHER O VETOR
            this.paciente.PreencherVetor();
            for (int i = 0; i < this.paciente.contar; i++)
            {
                dataGrid.Rows.Add(
                    this.paciente.codigo[i],
                    this.paciente.nome[i],
                    this.paciente.CPF[i],
                    this.paciente.dataNascimento[i].ToString("dd/MM/yyyy"),
                    this.paciente.tipoSanguineo[i],
                    this.paciente.telefone[i],
                    this.paciente.endereco[i],
                    this.paciente.convenio[i]
                );
            }
        }//fim do adicionarDados

        public DataGridView retornarData()
        {
            return dataGridView1;
        }
    }
}
