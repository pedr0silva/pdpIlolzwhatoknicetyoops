using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaUI
{
    public partial class Login : Form
    {
        public Loja superDume;        

        public Login(Loja superDume)
        {
            InitializeComponent();
            this.superDume = superDume;
            superDume.Credencias.CorrectPassword = false;

            //Leitura do botao Remember Me.
            if (LojaUI.Properties.Settings.Default.rememberMe)
            {
                txtUser.Text = LojaUI.Properties.Settings.Default.user;
                txtPass.Text = LojaUI.Properties.Settings.Default.password;
                checkRemMe.Checked = LojaUI.Properties.Settings.Default.rememberMe;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            superDume.Credencias.user = txtUser.Text;
            superDume.Credencias.password = txtPass.Text;

            foreach(string s in superDume.Credencias.userPass.Keys)
            {
                if(superDume.Credencias.user.Equals(s) && superDume.Credencias.password.Equals(superDume.Credencias.userPass[s]))
                {
                    //Guarda em propriedades os dados de acesso.
                    LojaUI.Properties.Settings.Default.user = txtUser.Text;
                    LojaUI.Properties.Settings.Default.password = txtPass.Text;
                    LojaUI.Properties.Settings.Default.rememberMe = checkRemMe.Checked;
                    LojaUI.Properties.Settings.Default.Save();

                    //Inicializa o login.
                    superDume.Credencias.CorrectPassword = true;
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("As credenciais que inseriu nao estao correctas!", "Erro de Autenticacao.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
