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
        public Credencial login;
        private Stream sw;          

        public Login(Credencial login, Stream s)
        {
            InitializeComponent();
            this.login = login;
            this.sw = s;

            if(login.rememberMe)
            {
                txtUser.Text = login.user;
                txtPass.Text = login.password;
                checkRemMe.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.CorrectPassword = false;
            login.user = txtUser.Text;
            login.password = txtPass.Text;
            login.rememberMe = checkRemMe.Checked;    
            foreach(string s in login.userPass.Keys)
            {
                if(login.user.Equals(s) && login.password.Equals(login.userPass[s]))
                {
                    login.CorrectPassword = true;

                   // Properties.Settings.Default.user
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(sw, this.login);
                    sw.Close();
                    this.Close();
                    break;
                }
            }
        }
    }
}
