using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace MenewUtils
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Logar()
        {
            if (txtSenha.Text == "937118")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Senha Inválida");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logar();
            }

        }
    }
}
