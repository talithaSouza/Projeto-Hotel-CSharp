using System;
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
    public partial class LoginForm : Form
    {
        string senha = "admin";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
          if(tb_senha.Text == senha)
            {
                Form_Main form_main = new Form_Main();
                
                form_main.ShowDialog();
            }
        }
    }
}
