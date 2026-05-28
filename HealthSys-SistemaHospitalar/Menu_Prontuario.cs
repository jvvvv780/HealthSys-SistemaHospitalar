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
    public partial class Menu_Prontuario : Form
    {
        Cadastrar_Prontuario cadastrarProntuario;
        Consultar_Prontuario consultarProntuario;
        Atualizar_Prontuario atualizarProntuario;
        Deletar_Prontuario deletarProntuario;

        public Menu_Prontuario()
        {
            InitializeComponent();
        }

        private void Button_CadastrarProntuario_Click(object sender, EventArgs e)
        {
            cadastrarProntuario = new Cadastrar_Prontuario();
            cadastrarProntuario.ShowDialog();
        }

        private void Menu_Prontuario_Load(object sender, EventArgs e)
        {

        }

        private void Button_ConsultarProntuario_Click(object sender, EventArgs e)
        {
            consultarProntuario = new Consultar_Prontuario();
            consultarProntuario.ShowDialog();
        }

        private void Button_AtualizarProntuario_Click(object sender, EventArgs e)
        {
            atualizarProntuario = new Atualizar_Prontuario();
            atualizarProntuario.ShowDialog();
        }

        private void Button_DeletarProntuario_Click(object sender, EventArgs e)
        {
            deletarProntuario = new Deletar_Prontuario();
            deletarProntuario.ShowDialog();
        }
    }
}
