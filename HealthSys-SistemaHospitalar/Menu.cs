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
    public partial class Menu : Form
    {
        Menu_Paciente menuPaciente;
        Menu_Medico menuMedico;
        Menu_Enfermeiro menuEnfermeiro;
        Menu_Leito menuLeito;
        Menu_Internacao menuInternacao;
        Menu_Exame menuExame;
        Menu_Prontuario menuProntuario;



        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Paciente_Click(object sender, EventArgs e)
        {
            menuPaciente = new Menu_Paciente();
            menuPaciente.ShowDialog();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Button_Medico_Click(object sender, EventArgs e)
        {
            menuMedico = new Menu_Medico();
            menuMedico.ShowDialog();
        }

        private void Button_Enfermeiro_Click(object sender, EventArgs e)
        {
            menuEnfermeiro = new Menu_Enfermeiro();
            menuEnfermeiro.ShowDialog();
        }

        private void Button_Leito_Click(object sender, EventArgs e)
        {
            menuLeito = new Menu_Leito();
            menuLeito.ShowDialog();
        }

        private void Button_Internacao_Click(object sender, EventArgs e)
        {
            menuInternacao = new Menu_Internacao();
            menuInternacao.ShowDialog();
        }

        private void Button_Exame_Click(object sender, EventArgs e)
        {
            menuExame = new Menu_Exame();
            menuExame.ShowDialog();
        }

        private void Button_Prontuario_Click(object sender, EventArgs e)
        {
            menuProntuario = new Menu_Prontuario();
            menuProntuario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuPaciente = new Menu_Paciente();
            menuPaciente.ShowDialog();
        }

        private void MiniButton_Medico_Click(object sender, EventArgs e)
        {
            menuMedico = new Menu_Medico();
            menuMedico.ShowDialog();
        }

        private void MiniButton_Enfermeiro_Click(object sender, EventArgs e)
        {
            menuEnfermeiro = new Menu_Enfermeiro();
            menuEnfermeiro.ShowDialog();
        }

        private void MiniButton_Leito_Click(object sender, EventArgs e)
        {
            menuLeito = new Menu_Leito();
            menuLeito.ShowDialog();
        }

        private void MiniButton_Internacao_Click(object sender, EventArgs e)
        {
            menuInternacao = new Menu_Internacao();
            menuInternacao.ShowDialog();
        }

        private void MiniButton_Exame_Click(object sender, EventArgs e)
        {
            menuExame = new Menu_Exame();
            menuExame.ShowDialog();
        }

        private void MiniButton_Prontuario_Click(object sender, EventArgs e)
        {
            menuProntuario = new Menu_Prontuario();
            menuProntuario.ShowDialog();
        }
    }
}
