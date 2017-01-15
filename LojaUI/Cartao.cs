using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaUI
{
    public partial class Cartao : Form
    {
        private Cliente c;
        public Cartao(Cliente c)
        {
            InitializeComponent();
            this.c = c;
            txtPontos.Text = c.Cartao.Pontos.ToString();

            gridCartao.Rows.Clear();

            foreach (Compra comp in c.Cartao.Lista_de_compras)
            {
                int index = gridCartao.Rows.Add();
                gridCartao.Rows[index].Cells[0].Value = comp.Codigo_Compra;
                gridCartao.Rows[index].Cells[1].Value = comp.Valor;
                gridCartao.Rows[index].Cells[2].Value = comp.Descricao;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            c.Cartao.Pontos = int.Parse(txtPontos.Text);
            this.Close();
        }
    }
}
