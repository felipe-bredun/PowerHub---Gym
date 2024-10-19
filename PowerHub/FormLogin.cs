using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PowerHub
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            if (txtusuario.Text == "admin" && txtsenha.Text == "admin")
            {
                MessageBox.Show("Acesso Liberado");
                Form1 formmain = new Form1();
                formmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Senha incorretos");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormRegistro formReg = new FormRegistro();
            formReg.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkboxmostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxmostrarsenha.Checked == true)
            {
                txtsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
            }


        }
    }
}
