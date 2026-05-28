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
    public partial class Cadastrar_Prontuario : Form
    {
        DAOProntuario prontuario;
        public Cadastrar_Prontuario()
        {
            InitializeComponent();
            this.prontuario = new DAOProntuario();
        }

        private void Cadastrar_Prontuario_Load(object sender, EventArgs e)
        {

        }

        private void Button_SalvarCadastrarProntuario_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox2.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string descricao = (textBox1.Text);
                DateTime dataProntuario = DateTime.Parse(textBox2.Text);

                this.prontuario.InserirProntuario(descricao, dataProntuario);

                LimparCampos();
            }//Fim do Método Cadastrar
        }//Fim do Button_SalvarCadastrarProntuario

        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }//fim do LimparCampos
    }
}
