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
    public partial class Atualizar_Paciente : Form
    {
        DAOPaciente paciente;

        public Atualizar_Paciente()
        {
            InitializeComponent();
            this.paciente = new DAOPaciente();
        }

        private void Button_SalvarAtualizarPaciente_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);

            //Atualizando os dados
            this.paciente.AtualizarPaciente(codigo, "nome", textBox2.Text);
            this.paciente.AtualizarPaciente(codigo, "CPF", textBox3.Text);
            this.paciente.AtualizarPaciente(codigo, "dataNascimento", textBox4.Text);
            this.paciente.AtualizarPaciente(codigo, "tipoSanguineo", textBox5.Text);
            this.paciente.AtualizarPaciente(codigo, "telefone", textBox6.Text);
            this.paciente.AtualizarPaciente(codigo, "endereco", textBox7.Text);
            string atualizar = this.paciente.AtualizarPaciente(codigo, "convenio", textBox8.Text);
            MessageBox.Show(atualizar);

            //Limpar os campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }//Fim do Button_SalvarAtualizarPaciente


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Button Código
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Button Nome
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Button CPF
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Button Data de Nascimento
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void Atualizar_Paciente_Load(object sender, EventArgs e)
        {

        }
    }
}
