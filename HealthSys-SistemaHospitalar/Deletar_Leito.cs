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
    public partial class Deletar_Leito : Form
    {
        DAOLeito leito;
        
        public Deletar_Leito()
        {
            InitializeComponent();
            this.leito = new DAOLeito();
        }

        private void Button_SalvarDeletarLeito_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha o código para excluir");
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);
                string excluir = this.leito.Deletar(codigo);
                //Mostrar o resultado na tela
                MessageBox.Show(excluir);
                //Limpar o campo
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
