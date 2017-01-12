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
        private Compra compraAux;

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

            comboArtigos.Items.AddRange(this.SuperDume.Dicionario_Artigos.Values.ToArray());
        }
        private void CriaTabelaCliente()
        {
            //Cria as colunas relevantes para os livros
            gridClientes.Columns.Clear();
            gridClientes.AutoGenerateColumns = false;
            gridClientes.Columns.Add("Nome", "Nome");
            gridClientes.Columns.Add("Identificacao", "Identificacao");
            gridClientes.Columns.Add("Contribuinte", "Contribuinte");
            gridClientes.Columns.Add("Morada", "Morada");
            gridClientes.Columns.Add("Email", "Email");
            gridClientes.Columns.Add("Telefone", "Telefone");

            //adiciona cada artigo existente na biblioteca à gridview
            foreach (Cliente cli in SuperDume.Dicionario_Clientes.Values)
            {
                int index = gridClientes.Rows.Add();
                gridClientes.Rows[index].Cells[0].Value = cli.Nome;
                gridClientes.Rows[index].Cells[1].Value = cli.CC;
                gridClientes.Rows[index].Cells[2].Value = cli.Nif;
                gridClientes.Rows[index].Cells[3].Value = cli.Morada;
                gridClientes.Rows[index].Cells[4].Value = cli.Email;
                gridClientes.Rows[index].Cells[5].Value = cli.Telemovel;
            }
        }
        private void CriarTabelaCompras()
        {
            foreach (Compra com in SuperDume.Dicionario_Compras.Values)
            {
                int index = gridClientes.Rows.Add();
                gridClientes.Rows[index].Cells[0].Value = com.Codigo_Compra;
                gridClientes.Rows[index].Cells[1].Value = com.OCliente.Nome;
                gridClientes.Rows[index].Cells[2].Value = com.Valor;
            }
        }
        private void CriarTabelaComprasArtigos(Compra comp)
        {
            foreach (Artigo art in comp.Artigos_comprados)
            {
                int index = gridComprasArtigos.Rows.Add();
                gridComprasArtigos.Rows[index].Cells[0].Value = comp.Artigos_comprados[index].Descricao;
                gridComprasArtigos.Rows[index].Cells[0].Value = comp.Artigos_comprados[index].Quantidade;
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

            compraAux = new Compra();

            CriaTabelaArtigo();
            CriaTabelaCliente();
            CriarTabelaCompras();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Stream s = File.Open("NuncaMeHackeareas.bin", FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, SuperDume);
            }
            else
            {
                e.Cancel = true;
            }
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
                    string codigo = gridArtigos.SelectedRows[0].Cells[0].Value.ToString();
                    SuperDume.EliminaArtigoForm(codigo);
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
                    if (!txtCodigo.Text.Trim().Equals("") && !txtPreco.Text.Trim().Equals("") && !txtStock.Text.Trim().Equals(""))
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

        private void gridArtigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridArtigos.SelectedRows.Count > 0)
            {
                txtCodigo.Text = gridArtigos.SelectedRows[0].Cells[0].Value.ToString();
                txtDesc.Text = gridArtigos.SelectedRows[0].Cells[1].Value.ToString();
                txtPreco.Text = gridArtigos.SelectedRows[0].Cells[2].Value.ToString();
                txtStock.Text = gridArtigos.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridClientes.SelectedRows.Count > 0)
            {
                txtNome.Text = gridClientes.SelectedRows[0].Cells[0].Value.ToString();
                txtCC.Text = gridClientes.SelectedRows[0].Cells[1].Value.ToString();
                txtNIF.Text = gridClientes.SelectedRows[0].Cells[2].Value.ToString();
                txtMorada.Text = gridClientes.SelectedRows[0].Cells[3].Value.ToString();
                txtEmail.Text = gridClientes.SelectedRows[0].Cells[4].Value.ToString();
                txtTele.Text = gridClientes.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
        private void btnAcrescentarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SuperDume.Dicionario_Clientes.ContainsKey(txtCC.Text))
                {
                    if (!txtCC.Text.Trim().Equals("") && !txtNome.Text.Trim().Equals("") && !txtNIF.Text.Trim().Equals("") && !txtMorada.Text.Trim().Equals(""))
                    {
                        int telemovel = 0;

                        try
                        {
                            telemovel = int.Parse(txtTele.Text);
                        }
                        catch
                        {
                            telemovel = 0;
                        }
                        Cliente cli = new Cliente(txtNome.Text, txtCC.Text, int.Parse(txtNIF.Text), txtMorada.Text, telemovel, txtEmail.Text);
                        SuperDume.Dicionario_Clientes.Add(cli.CC, cli);
                        CriaTabelaCliente();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("A identificacao introduzida é invalida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridClientes.SelectedRows.Count > 0)
                {
                    string codigo = gridClientes.SelectedRows[0].Cells[1].Value.ToString();
                    SuperDume.EliminaClienteForm(codigo);
                    CriaTabelaCliente();
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
        private void txtAlteracoesCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridClientes.SelectedRows.Count > 0)
                {
                    if (!txtNome.Text.Trim().Equals("") && !txtNIF.Text.Trim().Equals("") && !txtMorada.Text.Trim().Equals(""))
                    {
                        string cc = gridClientes.SelectedRows[0].Cells[1].Value.ToString();
                        if (SuperDume.Dicionario_Clientes.ContainsKey(cc))
                        {
                            SuperDume.Dicionario_Clientes[cc].Nome = txtNome.Text;
                            SuperDume.Dicionario_Clientes[cc].Nif = int.Parse(txtNIF.Text);
                            SuperDume.Dicionario_Clientes[cc].Morada = txtMorada.Text;
                            SuperDume.Dicionario_Clientes[cc].Email = txtEmail.Text;
                            SuperDume.Dicionario_Clientes[cc].Telemovel = int.Parse(txtTele.Text);
                        }
                        CriaTabelaCliente();
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

        private void gridComprasArtigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAcrescCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SuperDume.Dicionario_Compras.ContainsKey(txtCodigoCompra.Text))
                {
                    if (!txtCodigoCompra.Text.Trim().Equals("") && !txtNome.Text.Trim().Equals("") && !txtNIF.Text.Trim().Equals("") && !txtMorada.Text.Trim().Equals(""))
                    {
                        int telemovel = 0;

                        try
                        {
                            telemovel = int.Parse(txtTele.Text);
                        }
                        catch
                        {
                            telemovel = 0;
                        }
                        Cliente cli = new Cliente(txtNome.Text, txtCC.Text, int.Parse(txtNIF.Text), txtMorada.Text, telemovel, txtEmail.Text);
                        SuperDume.Dicionario_Clientes.Add(cli.CC, cli);
                        CriaTabelaCliente();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("A identificacao introduzida é invalida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcresArtigoCompra_Click(object sender, EventArgs e)
        {
            if (comboArtigos.SelectedIndex > -1)
            {
                compraAux.Artigos_comprados.Add((Artigo)comboArtigos.SelectedItem);
                CriarTabelaComprasArtigos(compraAux);
            }
            else
            {
                MessageBox.Show("Escolha um artigo.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarArtigoCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnCartaoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string ccaux = (string)gridClientes.SelectedRows[0].Cells[1].Value;
                Cliente cli;

                foreach (string cc in SuperDume.Dicionario_Clientes.Keys)
                {
                    try
                    {
                        if (cc == ccaux)
                        {
                            cli = SuperDume.Dicionario_Clientes[cc];
                            Application.Run(new Cartao_Cliente(cli));
                            break;
                        }      
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("O Cliente nao esta na base de dados!", "Erro");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Nao Seleccionou nenhum cliente!","Erro");
            }
        }
    }
    ;
}
