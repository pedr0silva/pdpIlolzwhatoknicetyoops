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
    public partial class Main : Form
    {
        public Loja SuperDume;

        private void CriaTabelaArtigo()
        {
            //Cria as colunas relevantes para os livros
            gridArtigos.Columns.Clear();
            gridArtigos.AutoGenerateColumns = false;
            gridArtigos.Columns.Add("Codigo", "Codigo");
            gridArtigos.Columns.Add("Descricao", "Descricao");
            gridArtigos.Columns.Add("Preco", "Preco");
            gridArtigos.Columns.Add("Stock", "Stock");

            //adiciona cada artigo existente na biblioteca à gridview
            foreach (Artigo art in SuperDume.Dicionario_Artigos.Values)
            {
                int index = gridArtigos.Rows.Add();
                gridArtigos.Rows[index].Cells[0].Value = art.Codigo_de_artigo;
                gridArtigos.Rows[index].Cells[1].Value = art.Descricao;
                gridArtigos.Rows[index].Cells[2].Value = art.Preco_unitario;
                gridArtigos.Rows[index].Cells[3].Value = art.Em_stock;
            }
        }

        public Main(Loja loj)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            this.SuperDume = loj;
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);
            CriaTabelaArtigo();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stream s = File.Open("NuncaMeHackeareas.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(s, SuperDume);
        }

        private void btnAcres_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SuperDume.Dicionario_Artigos.ContainsKey(int.Parse(txtCodigo.Text)))
                {
                    if (!txtCodigo.Text.Trim().Equals("") && !txtPreco.Text.Trim().Equals("") && !txtStock.Text.Trim().Equals(""))
                    {
                        Artigo art = new Artigo(int.Parse(txtCodigo.Text), txtDesc.Text, float.Parse(txtPreco.Text), int.Parse(txtStock.Text));
                        SuperDume.Dicionario_Artigos.Add(art.Codigo_de_artigo, art);
                        CriaTabelaArtigo();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O Codigo introduzido é invalido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridArtigos.SelectedRows.Count > 0)
                {
                    DataGridViewSelectedRowCollection selection = gridArtigos.SelectedRows;
                    foreach (DataGridViewRow r in selection)
                    {
                        string codigo = r.Cells[0].Value.ToString();
                        SuperDume.EliminaArtigoForm(codigo);
                    }
                    CriaTabelaArtigo();
                }
                else
                {
                    MessageBox.Show("Selecione o que deseja apagar.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridArtigos.SelectedRows.Count > 0)
                {
                    if(!txtCodigo.Text.Trim().Equals("") && !txtPreco.Text.Trim().Equals("") && !txtStock.Text.Trim().Equals(""))
                    {
                        string codigo = gridArtigos.SelectedRows[0].Cells[0].Value.ToString();
                        if (SuperDume.Dicionario_Artigos.ContainsKey(int.Parse(codigo)))
                        {
                            SuperDume.Dicionario_Artigos[int.Parse(codigo)].Descricao = txtDesc.Text;
                            SuperDume.Dicionario_Artigos[int.Parse(codigo)].Em_stock = int.Parse(txtStock.Text);
                            SuperDume.Dicionario_Artigos[int.Parse(codigo)].Preco_unitario = float.Parse(txtPreco.Text);
                        }
                        CriaTabelaArtigo();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Selecione o que deseja alterar.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridArtigos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridArtigos.SelectedRows.Count > 0)
            {
                txtCodigo.Text = gridArtigos.SelectedRows[0].Cells[0].Value.ToString();
                txtDesc.Text = gridArtigos.SelectedRows[0].Cells[1].Value.ToString();
                txtPreco.Text = gridArtigos.SelectedRows[0].Cells[2].Value.ToString();
                txtStock.Text = gridArtigos.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
