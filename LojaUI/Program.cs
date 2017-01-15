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

            Loja superDume = new Loja("Rua Direita", "Barcelos");

            //Verifica se os dados existem.
            if(File.Exists("NuncaMeHackeareas.bin"))
            {
                Stream s = File.Open("NuncaMeHackeareas.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                superDume = (Loja)bf.Deserialize(s);
                s.Close();
            }
            else
            {
                //Se nao existirem cria credenciais para poder fazer login.
                superDume.Credencias.FazUmaX();
            }

            //Corre o menu de login.
            Application.Run(new Login(superDume));

            if (superDume.Credencias.CorrectPassword)
            {
                Application.Run(new Main(superDume));
            }
        }
    }
}
