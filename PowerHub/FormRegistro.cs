using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerHub
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkboxmostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxmostrarsenharegistro.Checked == true)
            {
                txtsenharegistro.UseSystemPasswordChar = false;
                txtrepetirsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenharegistro.UseSystemPasswordChar = true;
                txtrepetirsenha.UseSystemPasswordChar = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Captura os valores dos campos
            string nome = txtnome.Text;
            string email = txtemail.Text;
            string senha = txtsenharegistro.Text;
            string repetirSenha = txtrepetirsenha.Text;

            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(repetirSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verifica se as senhas coincidem
            if (senha != repetirSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            // Cria o caminho do arquivo .txt onde os dados serão armazenados
            string caminhoArquivo = @"C:\Users\User\Desktop\Programação\PowerHub\usuarios.txt";

            try
            {
                // Cria o diretório se ele não existir
                Directory.CreateDirectory(Path.GetDirectoryName(caminhoArquivo));

                // Salva os dados no arquivo .txt
                using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
                {
                    sw.WriteLine($"Nome: {nome}, Email: {email}, Senha: {senha}");
                }

                MessageBox.Show("Cadastro realizado com sucesso!");

                // Limpa os campos após o cadastro
                txtnome.Clear();
                txtemail.Clear();
                txtsenharegistro.Clear();
                txtrepetirsenha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o cadastro: {ex.Message}");
            }
        }

        private void lblVoltarLogin_Click(object sender, EventArgs e)
        {
            FormLogin formloginn = new FormLogin();
            formloginn.Show();
            this.Hide();
        }

        private void lblsenha_Click(object sender, EventArgs e)
        {

        }

        private void txtsenharegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblrepetirsenha_Click(object sender, EventArgs e)
        {

        }
    }
}
