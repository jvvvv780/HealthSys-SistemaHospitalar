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

    public partial class Consultar_Leito : Form
    {
        DAOLeito leito;

        public Consultar_Leito()
        {
            InitializeComponent();
            this.leito = new DAOLeito();
            ChamarMetodo(dataGridView1);//Configurar toda a estrutura
        }

        private void Consultar_Leito_Load(object sender, EventArgs e)
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
            if (dataGrid.Columns.Count >= 4)
            {
                dataGrid.Columns[0].Name = "Código";
                dataGrid.Columns[1].Name = "Número";
                dataGrid.Columns[2].Name = "Setor";
                dataGrid.Columns[3].Name = "Status do Leito";
            }

                
        }//fim do método

        //Definir a estrutura da tabela
        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false;//Não permito que o usuário adicione linhas
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;

            dataGrid.ColumnCount = 4;
        }//fim do configurar

        public void AdicionarDados(DataGridView dataGrid)
        {
            //Primeira coisa será: PREENCHER O VETOR
            this.leito.PreencherVetor();
            for (int i = 0; i < this.leito.contar; i++)
            {
                dataGrid.Rows.Add(
                    this.leito.codigo[i],
                    this.leito.numero[i],
                    this.leito.setor[i],
                    this.leito.statusLeito[i]
                    
                );
            }
        }//fim do adicionarDados

        public DataGridView retornarData()
        {
            return dataGridView1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}