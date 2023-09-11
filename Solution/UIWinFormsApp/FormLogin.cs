using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Tag = false;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                    new UsuarioBLL().Altenicar(textBoxUsuario.Text, textBoxSenha.Text);
                    Tag = true;
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
