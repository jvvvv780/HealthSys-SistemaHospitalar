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
    public partial class Atualizar_Leito : Form
    {

        DAOLeito leito;

        public Atualizar_Leito()
        {
            InitializeComponent();
            this.leito = new DAOLeito();
        }

        private void Atualizar_Leito_Load(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);

            this.leito.AtualizarLeito(codigo, "numero", textBox2.Text);
            this.leito.AtualizarLeito(codigo, "setor", textBox3.Text);
            string atualizar = this.leito.AtualizarLeito(codigo, "statusLeito", textBox4.Text);
            MessageBox.Show(atualizar);

            //Limpar os campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            

        }//Fim do Button_SalvarAtualizarLeito

        private void Button_SalvarAtualizarLeito_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //codigo
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //num
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //setor
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //status
        }
    }
}
