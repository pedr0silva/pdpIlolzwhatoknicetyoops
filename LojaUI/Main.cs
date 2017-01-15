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
            gridArtigos.Rows.Clear();

            //Adiciona cada artigo existente na Loja à gridview.
            foreach (Artigo art in SuperDume.Dicionario_Artigos.Values)
            {
                int index = gridArtigos.Rows.Add();
                gridArtigos.Rows[index].Cells[0].Value = art.Codigo_de_artigo;
                gridArtigos.Rows[index].Cells[1].Value = art.Descricao;
                gridArtigos.Rows[index].Cells[2].Value = art.Preco_unitario;
                gridArtigos.Rows[index].Cells[3].Value = art.Em_stock;
            }

            //Adiciona no ComboBox das compras os artigos.
            comboArtigos.Items.Clear();
            comboArtigos.Items.AddRange(this.SuperDume.Dicionario_Artigos.Values.ToArray());
        }
        private void CriaTabelaCliente()
        {
            //Cria as colunas relevantes.
            gridClientes.Rows.Clear();

            //Adiciona cada Cliente existente na Loja à gridview
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

            //Adiciona no ComboBox das compras os Clientes.
            comboClienteCompra.Items.Clear();
            comboClienteCompra.Items.AddRange(this.SuperDume.Dicionario_Clientes.Values.ToArray());
        }
        private void CriarTabelaCompras()
        {
            //Cria as colunas relevantes.
            gridCompras.Rows.Clear();

            //Adiciona cada Compra existente na Loja à gridview
            foreach (string com in SuperDume.Dicionario_Compras.Keys)
            {
                int index = gridCompras.Rows.Add();
                gridCompras.Rows[index].Cells[0].Value = SuperDume.Dicionario_Compras[com].Codigo_Compra;
                gridCompras.Rows[index].Cells[1].Value = SuperDume.Dicionario_Compras[com].OCliente.Nome;
                gridCompras.Rows[index].Cells[2].Value = SuperDume.Dicionario_Compras[com].Valor.ToString();
            }
        }
        private void CriarTabelaComprasArtigos(Compra comp)
        {
            //Adiciona cada Artigo da compra escolhida na gridview.
            gridComprasArtigos.Rows.Clear();
            foreach (Artigo art in comp.Artigos_comprados)
            {
                int index = gridComprasArtigos.Rows.Add();
                gridComprasArtigos.Rows[index].Cells[1].Value = comp.Artigos_comprados[index].Descricao;
                gridComprasArtigos.Rows[index].Cells[2].Value = comp.Artigos_comprados[index].Quantidade;
                gridComprasArtigos.Rows[index].Cells[0].Value = comp.Artigos_comprados[index].Codigo_de_artigo;
            }
        }
        private void LimparCompra()
        {
            compraAux = new Compra();
            CriarTabelaComprasArtigos(compraAux);
            if (SuperDume.Dicionario_Compras.Count() == 0)
            {
                txtCodigoCompra.Text = "1";
            }
            else
            {
                txtCodigoCompra.Text = (int.Parse(SuperDume.Dicionario_Compras.Keys.Max()) + 1).ToString();
            }
            txtDecricaoCompra.Text = "";
            txtQuantidadeCompra.Text = "";
            txtCompraValor.Text = "";
            gridCompras.ClearSelection();
            gridComprasArtigos.ClearSelection();
        }
        private void LimpaArtigo()
        {
            if (SuperDume.Dicionario_Artigos.Count() == 0)
            {
                txtCodigo.Text = "1";
            }
            else
            {
                txtCodigo.Text = (SuperDume.Dicionario_Artigos.Keys.Max() + 1).ToString();
            }
            txtPreco.Text = "";
            txtStock.Text = "";
            txtDesc.Text = "";
            gridArtigos.ClearSelection();
        }
        private void LimpaCliente()
        {
            txtNome.Text = "";
            txtCC.Text = "";
            txtNIF.Text = "";
            txtMorada.Text = "";
            txtEmail.Text = "";
            txtTele.Text = "";
            gridClientes.ClearSelection();
        }

        public Main(Loja loj)
        {
            InitializeComponent();

            this.SuperDume = loj;
            compraAux = new Compra();

            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);

            //Gera as tabelas.
            CriaTabelaArtigo();
            CriaTabelaCliente();
            CriarTabelaCompras();
            LimparCompra();
            LimpaArtigo();
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

        //ARTIGOS
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
                        LimpaArtigo();
                    }
                    else
                    {
                        throw new Exception("Preencha todos os campos.");
                    }
                }
                else
                {
                    throw new Exception("O Codigo introduzido é invalido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            LimpaArtigo();
                            LimparCompra();
                            CriaTabelaArtigo();
                            CriarTabelaCompras();
                        }
                        else
                        {
                            throw new Exception("Algo deu errado.");
                        }                     
                    }
                    else
                    {
                        throw new Exception("Preencha todos os campos.");
                    }
                }
                else
                {
                    throw new Exception("Selecione o que deseja alterar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    LimpaArtigo();
                    CriaTabelaArtigo();
                }
                else
                {
                    throw new Exception("Selecione o que deseja apagar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnArtigoCancelar_Click_1(object sender, EventArgs e)
        {
            LimpaArtigo();
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

        //CLIENTES
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
                        LimpaCliente();
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

                            CriaTabelaCliente();
                            CriarTabelaCompras();
                            LimparCompra();
                            LimpaCliente();
                        }
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
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridClientes.SelectedRows.Count > 0)
                {
                    string codigo = gridClientes.SelectedRows[0].Cells[1].Value.ToString();
                    SuperDume.EliminaClienteForm(codigo);
                    CriaTabelaCliente();
                    LimpaCliente();
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
        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            LimpaCliente();
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

        //COMPRAS
        private void btnAcrescCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SuperDume.Dicionario_Compras.ContainsKey(txtCodigoCompra.Text))
                {
                    if (!txtCodigoCompra.Text.Trim().Equals("") && comboClienteCompra.SelectedIndex > -1 && compraAux.Artigos_comprados.Count() > 0)
                    {
                        compraAux.Codigo_Compra = txtCodigoCompra.Text;
                        compraAux.OCliente = (Cliente)comboClienteCompra.SelectedItem;
                        compraAux.OCliente.Cartao.Lista_de_compras.Add(compraAux);
                        compraAux.OCliente.CalculaPontos();

                        foreach (Artigo art in SuperDume.Dicionario_Artigos.Values)
                        {
                            foreach (Artigo art2 in compraAux.Artigos_comprados)
                            {
                                if (art.Codigo_de_artigo.Equals(art2.Codigo_de_artigo) && art.Em_stock < art2.Quantidade)
                                {
                                    throw new Exception("Nao ha stock.");
                                }
                            }
                        }
                      
                        SuperDume.Dicionario_Compras.Add(compraAux.Codigo_Compra, compraAux);
                        SuperDume.ActualizaStock(compraAux);

                        CriarTabelaCompras();
                        CriaTabelaArtigo();
                        LimparCompra();
                    }
                    else
                    {
                        throw new Exception("Preencha todos os campos.");
                    }
                }
                else
                {
                    throw new Exception("A identificacao introduzida é invalida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAceitarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridCompras.SelectedRows.Count > 0)
                {
                    if (!txtCodigoCompra.Text.Trim().Equals("") && comboClienteCompra.SelectedIndex > -1 && compraAux.Artigos_comprados.Count() > 0)
                    {
                        compraAux.OCliente = (Cliente)comboClienteCompra.SelectedItem;
                        compraAux.Descricao = txtDecricaoCompra.Text;

                        SuperDume.Dicionario_Compras[gridCompras.SelectedRows[0].Cells[0].Value.ToString()] = compraAux;
                        SuperDume.ActualizaStock(compraAux);
                        CriarTabelaCompras();
                        CriaTabelaArtigo();
                    }
                    else
                    {
                        throw new Exception("Preencha todos os campos.");
                    }
                }
                else
                {
                    throw new Exception("Selecione uma compra.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            if (gridCompras.SelectedRows.Count > 0)
            {
                string stringAux = gridCompras.Rows[0].Cells[0].Value.ToString();
                foreach (Compra com in SuperDume.Dicionario_Compras.Values)
                {
                    if (com.Codigo_Compra.Equals(stringAux))
                    {
                        com.OCliente.Cartao.Lista_de_compras.Remove(com);
                        com.OCliente.CalculaPontos();
                        SuperDume.DevolveStock(com);
                        SuperDume.Dicionario_Compras.Remove(stringAux);

                        CriarTabelaCompras();
                        CriaTabelaArtigo();
                        LimparCompra();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um artigo.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCompraCancelar_Click(object sender, EventArgs e)
        {
            LimparCompra();
        }
        private void gridCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCompras.SelectedRows.Count > 0)
            {
                foreach (Compra com in SuperDume.Dicionario_Compras.Values)
                {
                    if (com.Codigo_Compra.Equals(gridCompras.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        txtCodigoCompra.Text = com.Codigo_Compra;
                        txtDecricaoCompra.Text = com.Descricao;
                        txtCompraValor.Text = com.Valor.ToString();
                        compraAux = com;

                        foreach (Cliente cli in SuperDume.Dicionario_Clientes.Values)
                        {
                            int i = 0;
                            if (cli.CC.Equals(com.OCliente.CC))
                            {
                                comboClienteCompra.SelectedIndex = i;
                            }
                            i++;
                        }

                        CriarTabelaComprasArtigos(com);
                        break;

                    }
                }
            }
        }


        //ARTIGOS DA COMPRA
        private void btnAcresArtigoCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboArtigos.SelectedIndex > -1)
                {
                    if (!txtQuantidadeCompra.Text.Trim().Equals(""))
                    {
                        Artigo artAux = (Artigo)comboArtigos.SelectedItem;
                        Artigo artAux2 = (Artigo)artAux.Clone();

                        artAux2.Quantidade = int.Parse(txtQuantidadeCompra.Text);
                        compraAux.Artigos_comprados.Add(artAux2);
                        compraAux.CalculaValorCompra();
                        txtCompraValor.Text = compraAux.Valor.ToString();
                        CriarTabelaComprasArtigos(compraAux);
                    }
                    else
                    {
                        throw new Exception("Introduza uma quantidade.");
                    }
                }
                else
                {
                    throw new Exception("Escolha um artigo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEliminarArtigoCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridComprasArtigos.SelectedRows.Count > 0)
                {
                    int intAux = (int)gridComprasArtigos.Rows[0].Cells[0].Value;
                    foreach (Artigo art in compraAux.Artigos_comprados)
                    {
                        if (art.Codigo_de_artigo == intAux)
                        {
                            compraAux.Artigos_comprados.Remove(art);
                            break;
                        }
                    }
                    compraAux.CalculaValorCompra();
                    txtCompraValor.Text = compraAux.Valor.ToString();
                    CriarTabelaComprasArtigos(compraAux);
                }
                else
                {
                    throw new Exception("Selecione um artigo.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CARTAO CLIENTE
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

                            Cartao c = new Cartao(cli);
                            c.ShowDialog();
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("O Cliente nao esta na base de dados!", "Erro");
                        MessageBox.Show("Errp: " + ex.Message, "Erro");

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nao Seleccionou nenhum cliente!", "Erro");
            }
        }        
    }
}
