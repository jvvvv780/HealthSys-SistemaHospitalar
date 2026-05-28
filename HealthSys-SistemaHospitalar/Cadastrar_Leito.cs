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
    public partial class Cadastrar_Leito : Form
    {
        DAOLeito leito;
        public Cadastrar_Leito()
        {
            InitializeComponent();
            this.leito = new DAOLeito();
        }

        private void Cadastrar_Leito_Load(object sender, EventArgs e)
        {

        }

        private void Button_SalvarCadastrarLeito_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                int numero = int.Parse(textBox1.Text);
                string setor = (textBox2.Text);
                string statusLeito = (textBox3.Text);

                this.leito.InserirLeito(numero, setor, statusLeito);

                LimparCampos();
            }//Fim do Método Cadastrar
        }//Fim do Button_SalvarCadastrarLeito

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }//fim do LimparCampos

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
