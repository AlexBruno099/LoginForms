﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            while (CadastroUsuario.UsuarioLogado == null) 
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogin.Cancelar == true)
                {
                    Application.Exit();
                    return;
                }
            }

            label1_BoasVindas.Text = "Bem Vindo(a) \n" + CadastroUsuario.UsuarioLogado.Nome;
            Visible = true;

        }
    }
}
