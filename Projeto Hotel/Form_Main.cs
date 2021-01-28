﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Hotel
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gerenciarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciar_Clientes formGerenciar_Clientes = new FormGerenciar_Clientes();

            formGerenciar_Clientes.ShowDialog();
        }
    }
}
