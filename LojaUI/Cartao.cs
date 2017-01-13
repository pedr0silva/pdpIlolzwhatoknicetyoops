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
        public Cartao(Cliente c)
        {
            InitializeComponent();
            txtPontos.Text = c.Cartao.Pontos.ToString();

            gridCartao.Columns.Clear();
            gridCartao.AutoGenerateColumns = false;
            gridCartao.Columns.Add("CodigoCompra", "Codigo");
            gridCartao.Columns.Add("ValorCartao", "Valor");
            gridCartao.Columns.Add("DescricaoCartao", "Descricao");

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
            this.Close();
        }
    }
}
