using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace LojaUI
{
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

            Loja superDume = new Loja();

            Stream s = File.Open("NuncaMeHackeareas.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            superDume = (Loja)bf.Deserialize(s);
            //Credencial logins = new Credencial();
            //logins = (Credencial)bf.Deserialize(s);

            Application.Run(new Login(superDume));

            if (superDume.Credencias.CorrectPassword)
            {
                Application.Run(new Main(superDume));
            }


        }
    }
}
