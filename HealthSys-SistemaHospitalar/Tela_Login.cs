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
    public partial class Tela_Login : Form
    {
        Menu menu;
        Cadastrar_Paciente cadastrarPaciente;
        DAOPaciente daoPaciente;

        public Tela_Login()
        {
            InitializeComponent();
            menu = new Menu();
            daoPaciente = new DAOPaciente();
        }

        private void Tela_Login_Load(object sender, EventArgs e)
        {

        }

        private void Button_EntrarLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Preencha os campos");
                return;
            }

            string nome = textBox1.Text;
            string CPF = textBox2.Text;

            bool loginOk = daoPaciente.ValidarLoginPaciente(nome, CPF);

            if (loginOk)
            {
                MessageBox.Show("Bem-vindo!");
                menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
