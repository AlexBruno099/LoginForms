using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForms
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnSenha_Click(object sender, EventArgs e)
        {
            string nome = textUsuario.Text;
            string senha = textSenha.Text;

            if (CadastroUsuario.Login(nome, senha))
            {
                Close();
            } else
            {
                MessageBox.Show("Acesso Negado!");
                textUsuario.Text = "";
                textSenha.Text = "";
                textUsuario.Focus();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
