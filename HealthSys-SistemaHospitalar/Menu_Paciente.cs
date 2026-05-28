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
    public partial class Menu_Paciente : Form
    {
        Cadastrar_Paciente cadastrarPaciente;
        Consultar_Paciente consultarPaciente;
        Atualizar_Paciente atualizarPaciente;
        Deletar_Paciente deletarPaciente;
        public Menu_Paciente()
        {
            InitializeComponent();
        }

        private void Button_CadastrarPaciente_Click(object sender, EventArgs e)
        {
            cadastrarPaciente = new Cadastrar_Paciente();
            cadastrarPaciente.ShowDialog();
        }

        private void Button_ConsultarPaciente_Click(object sender, EventArgs e)
        {
            consultarPaciente = new Consultar_Paciente();
            consultarPaciente.ShowDialog();
        }

        private void Button_AtualizarPaciente_Click(object sender, EventArgs e)
        {
            atualizarPaciente = new Atualizar_Paciente();
            atualizarPaciente.ShowDialog();
        }

        private void Button_DeletarPaciente_Click(object sender, EventArgs e)
        {
            deletarPaciente = new Deletar_Paciente();
            deletarPaciente.ShowDialog();
        }

        private void Menu_Paciente_Load(object sender, EventArgs e)
        {

        }
    }
}
