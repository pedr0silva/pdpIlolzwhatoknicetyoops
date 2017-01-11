using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace LojaUI
{
    [Serializable]
    public class Credencial
    {
        public bool CorrectPassword;
        public bool rememberMe;
        public string user;
        public string password;
        public Dictionary<string, string> userPass;

        public Credencial()
        {

        }

        public void FazUmaX()
        {
            userPass = new Dictionary<string, string>();
            userPass.Add("admin", "admin");
            userPass.Add("Daniela", "paradigmas");
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Stream s = File.Open("NuncaMeHackeareas.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            Credencial logins = new Credencial();
            logins = (Credencial)bf.Deserialize(s);

            Application.Run(new Login(logins, s));

            if (logins.CorrectPassword)
            {
                Application.Run(new Main());
            }
        }
    }
}
