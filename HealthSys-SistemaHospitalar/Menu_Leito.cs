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
    public partial class Menu_Leito : Form
    {
        Cadastrar_Leito cadastrarLeito;
        Consultar_Leito consultarLeito;
        Atualizar_Leito atualizarLeito;
        Deletar_Leito deletarLeito;

        public Menu_Leito()
        {
            InitializeComponent();
        }

        private void Menu_Leito_Load(object sender, EventArgs e)
        {

        }

        private void Button_CadastrarLeito_Click(object sender, EventArgs e)
        {
            cadastrarLeito = new Cadastrar_Leito();
            cadastrarLeito.ShowDialog();
        }

        private void Button_ConsultarLeito_Click(object sender, EventArgs e)
        {
            consultarLeito = new Consultar_Leito();
            consultarLeito.ShowDialog();
        }

        private void Button_AtualizarLeito_Click(object sender, EventArgs e)
        {
            atualizarLeito = new Atualizar_Leito();
            atualizarLeito.ShowDialog();
        }

        private void Button_DeletarLeito_Click(object sender, EventArgs e)
        {
            deletarLeito = new Deletar_Leito();
            deletarLeito.ShowDialog();
        }
    }
}
