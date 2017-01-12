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
    public partial class Cartao_Cliente : Form
    {
        public Cartao_Cliente(Cliente c)
        {
            InitializeComponent();
            txtPontos.Text = c.Cartao.Pontos.ToString();

            gridCartao.Columns.Clear();
            gridCartao.AutoGenerateColumns = false;
            gridCartao.Columns.Add("Codigo", "Codigo");
            gridCartao.Columns.Add("Descricao", "Descricao");
            gridCartao.Columns.Add("Preco", "Preco");
            gridCartao.Columns.Add("Quantidade", "Quantidade");

            foreach (Compra comp in c.Cartao.Lista_de_compras)
            {
                int index = gridCartao.Rows.Add();
                gridCartao.Rows[index].Cells[0].Value = comp.Artigos_comprados;
                gridCartao.Rows[index].Cells[1].Value = comp.Valor;
                gridCartao.Rows[index].Cells[2].Value = comp.Descricao;
                
            }
        }
    }
}
