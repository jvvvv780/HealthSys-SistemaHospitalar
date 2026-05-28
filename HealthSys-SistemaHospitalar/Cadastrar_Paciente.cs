using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthSys_SistemaHospitalar
{
    public partial class Cadastrar_Paciente : Form
    {
        DAOPaciente paciente;
        public Cadastrar_Paciente()
        {
            InitializeComponent();
            this.paciente = new DAOPaciente();
        }

        private void Cadastrar_Paciente_Load(object sender, EventArgs e)
        {

        }

        private void Button_SalvarCadastrarPaciente_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string nome = textBox1.Text;
                DateTime dataNascimento = DateTime.Parse(textBox2.Text);
                long CPF = long.Parse(textBox3.Text);
                string tipoSanguineo = textBox4.Text;
                string telefone = textBox6.Text;
                string endereco = textBox7.Text;
                string convenio = textBox8.Text;

                this.paciente.InserirPaciente(nome, CPF, dataNascimento, tipoSanguineo, telefone, endereco, convenio);

                LimparCampos();
            }//Fim do Método Cadastrar
        }//Fim do Button_SalvarCadastrarPaciente

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }//fim do LimparCampos

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Button Nome
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Button Data de Nascimento
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Button CPF
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Button Tipo Sanguíneo
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Button Telefone
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Button Endereço
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //Button Convênio
        }
    }
}
