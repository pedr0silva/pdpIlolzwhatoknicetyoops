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

            if(superDume.Credencias.rememberMe)
            {
                txtUser.Text = superDume.Credencias.user;
                txtPass.Text = superDume.Credencias.password;
                checkRemMe.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            superDume.Credencias.CorrectPassword = false;
            superDume.Credencias.user = txtUser.Text;
            superDume.Credencias.password = txtPass.Text;
            superDume.Credencias.rememberMe = checkRemMe.Checked;    
            foreach(string s in superDume.Credencias.userPass.Keys)
            {
                if(superDume.Credencias.user.Equals(s) && superDume.Credencias.password.Equals(superDume.Credencias.userPass[s]))
                {
                    superDume.Credencias.CorrectPassword = true;

                   // Properties.Settings.Default.user
                    this.Close();
                    break;
                }
            }
        }
    }
}
