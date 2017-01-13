namespace LojaUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridArtigos = new System.Windows.Forms.DataGridView();
            this.btnAcres = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCartaoCliente = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAcrescentarCliente = new System.Windows.Forms.Button();
            this.txtAlteracoesCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantidadeCompra = new System.Windows.Forms.TextBox();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.comboArtigos = new System.Windows.Forms.ComboBox();
            this.comboClienteCompra = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEliminarArtigoCompra = new System.Windows.Forms.Button();
            this.btnAcresArtigoCompra = new System.Windows.Forms.Button();
            this.gridComprasArtigos = new System.Windows.Forms.DataGridView();
            this.CodigoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarCompra = new System.Windows.Forms.Button();
            this.btnAcrescCompra = new System.Windows.Forms.Button();
            this.btnAceitarCompra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDecricaoCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompraValor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigoCompra = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArtigos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComprasArtigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridArtigos);
            this.tabPage1.Controls.Add(this.btnAcres);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnAceitar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDesc);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPreco);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtStock);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artigos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridArtigos
            // 
            this.gridArtigos.AllowUserToAddRows = false;
            this.gridArtigos.AllowUserToDeleteRows = false;
            this.gridArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArtigos.Location = new System.Drawing.Point(6, 6);
            this.gridArtigos.MultiSelect = false;
            this.gridArtigos.Name = "gridArtigos";
            this.gridArtigos.ReadOnly = true;
            this.gridArtigos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArtigos.Size = new System.Drawing.Size(796, 369);
            this.gridArtigos.TabIndex = 0;
            this.gridArtigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArtigos_CellClick);
            // 
            // btnAcres
            // 
            this.btnAcres.Location = new System.Drawing.Point(576, 382);
            this.btnAcres.Name = "btnAcres";
            this.btnAcres.Size = new System.Drawing.Size(110, 23);
            this.btnAcres.TabIndex = 6;
            this.btnAcres.Text = "Acrescentar Artigo";
            this.btnAcres.UseVisualStyleBackColor = true;
            this.btnAcres.Click += new System.EventHandler(this.btnAcres_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(692, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Artigo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(460, 382);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(110, 23);
            this.btnAceitar.TabIndex = 5;
            this.btnAceitar.Text = "Aceitar Alterações";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(70, 410);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(732, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(239, 384);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(394, 384);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(60, 20);
            this.txtStock.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 384);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(129, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCartaoCliente);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtTele);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.gridClientes);
            this.tabPage2.Controls.Add(this.btnEliminarCliente);
            this.tabPage2.Controls.Add(this.btnAcrescentarCliente);
            this.tabPage2.Controls.Add(this.txtAlteracoesCliente);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtMorada);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtCC);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtNIF);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCartaoCliente
            // 
            this.btnCartaoCliente.Location = new System.Drawing.Point(564, 383);
            this.btnCartaoCliente.Name = "btnCartaoCliente";
            this.btnCartaoCliente.Size = new System.Drawing.Size(116, 23);
            this.btnCartaoCliente.TabIndex = 9;
            this.btnCartaoCliente.Text = "Cartão de Cliente";
            this.btnCartaoCliente.UseVisualStyleBackColor = true;
            this.btnCartaoCliente.Click += new System.EventHandler(this.btnCartaoCliente_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(389, 354);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(457, 383);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(101, 20);
            this.txtTele.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(348, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Telefone:";
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(6, 8);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(796, 340);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellClick);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(686, 383);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(116, 23);
            this.btnEliminarCliente.TabIndex = 10;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAcrescentarCliente
            // 
            this.btnAcrescentarCliente.Location = new System.Drawing.Point(685, 354);
            this.btnAcrescentarCliente.Name = "btnAcrescentarCliente";
            this.btnAcrescentarCliente.Size = new System.Drawing.Size(117, 23);
            this.btnAcrescentarCliente.TabIndex = 8;
            this.btnAcrescentarCliente.Text = "Acrescentar Cliente";
            this.btnAcrescentarCliente.UseVisualStyleBackColor = true;
            this.btnAcrescentarCliente.Click += new System.EventHandler(this.btnAcrescentarCliente_Click);
            // 
            // txtAlteracoesCliente
            // 
            this.txtAlteracoesCliente.Location = new System.Drawing.Point(564, 354);
            this.txtAlteracoesCliente.Name = "txtAlteracoesCliente";
            this.txtAlteracoesCliente.Size = new System.Drawing.Size(116, 23);
            this.txtAlteracoesCliente.TabIndex = 7;
            this.txtAlteracoesCliente.Text = "Aceitar Alterações";
            this.txtAlteracoesCliente.UseVisualStyleBackColor = true;
            this.txtAlteracoesCliente.Click += new System.EventHandler(this.txtAlteracoesCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Morada:";
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(58, 412);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(744, 20);
            this.txtMorada.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Identificação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contribuinte:";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(83, 383);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(146, 20);
            this.txtCC.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nome:";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(307, 383);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(86, 20);
            this.txtNIF.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 354);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(292, 20);
            this.txtNome.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtQuantidadeCompra);
            this.tabPage3.Controls.Add(this.btnNovaCompra);
            this.tabPage3.Controls.Add(this.comboArtigos);
            this.tabPage3.Controls.Add(this.comboClienteCompra);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btnEliminarArtigoCompra);
            this.tabPage3.Controls.Add(this.btnAcresArtigoCompra);
            this.tabPage3.Controls.Add(this.gridComprasArtigos);
            this.tabPage3.Controls.Add(this.gridCompras);
            this.tabPage3.Controls.Add(this.btnEliminarCompra);
            this.tabPage3.Controls.Add(this.btnAcrescCompra);
            this.tabPage3.Controls.Add(this.btnAceitarCompra);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtDecricaoCompra);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtCompraValor);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtCodigoCompra);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(808, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compras";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Quantidade:";
            // 
            // txtQuantidadeCompra
            // 
            this.txtQuantidadeCompra.Location = new System.Drawing.Point(572, 248);
            this.txtQuantidadeCompra.Name = "txtQuantidadeCompra";
            this.txtQuantidadeCompra.Size = new System.Drawing.Size(39, 20);
            this.txtQuantidadeCompra.TabIndex = 28;
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.Location = new System.Drawing.Point(498, 382);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(113, 23);
            this.btnNovaCompra.TabIndex = 27;
            this.btnNovaCompra.Text = "Nova Compra";
            this.btnNovaCompra.UseVisualStyleBackColor = true;
            this.btnNovaCompra.Click += new System.EventHandler(this.btnNovaCompra_Click);
            // 
            // comboArtigos
            // 
            this.comboArtigos.FormattingEnabled = true;
            this.comboArtigos.Location = new System.Drawing.Point(504, 221);
            this.comboArtigos.Name = "comboArtigos";
            this.comboArtigos.Size = new System.Drawing.Size(297, 21);
            this.comboArtigos.TabIndex = 26;
            // 
            // comboClienteCompra
            // 
            this.comboClienteCompra.FormattingEnabled = true;
            this.comboClienteCompra.Location = new System.Drawing.Point(547, 328);
            this.comboClienteCompra.Name = "comboClienteCompra";
            this.comboClienteCompra.Size = new System.Drawing.Size(256, 21);
            this.comboClienteCompra.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(501, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Cliente:";
            // 
            // btnEliminarArtigoCompra
            // 
            this.btnEliminarArtigoCompra.Location = new System.Drawing.Point(727, 248);
            this.btnEliminarArtigoCompra.Name = "btnEliminarArtigoCompra";
            this.btnEliminarArtigoCompra.Size = new System.Drawing.Size(74, 23);
            this.btnEliminarArtigoCompra.TabIndex = 23;
            this.btnEliminarArtigoCompra.Text = "Eliminar";
            this.btnEliminarArtigoCompra.UseVisualStyleBackColor = true;
            this.btnEliminarArtigoCompra.Click += new System.EventHandler(this.btnEliminarArtigoCompra_Click);
            // 
            // btnAcresArtigoCompra
            // 
            this.btnAcresArtigoCompra.Location = new System.Drawing.Point(635, 248);
            this.btnAcresArtigoCompra.Name = "btnAcresArtigoCompra";
            this.btnAcresArtigoCompra.Size = new System.Drawing.Size(74, 23);
            this.btnAcresArtigoCompra.TabIndex = 22;
            this.btnAcresArtigoCompra.Text = "Acrescentar";
            this.btnAcresArtigoCompra.UseVisualStyleBackColor = true;
            this.btnAcresArtigoCompra.Click += new System.EventHandler(this.btnAcresArtigoCompra_Click);
            // 
            // gridComprasArtigos
            // 
            this.gridComprasArtigos.AllowUserToAddRows = false;
            this.gridComprasArtigos.AllowUserToDeleteRows = false;
            this.gridComprasArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComprasArtigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCompra,
            this.Descricao,
            this.Quantidade});
            this.gridComprasArtigos.Location = new System.Drawing.Point(504, 6);
            this.gridComprasArtigos.Name = "gridComprasArtigos";
            this.gridComprasArtigos.ReadOnly = true;
            this.gridComprasArtigos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridComprasArtigos.Size = new System.Drawing.Size(299, 209);
            this.gridComprasArtigos.TabIndex = 20;
            // 
            // CodigoCompra
            // 
            this.CodigoCompra.HeaderText = "Codigo";
            this.CodigoCompra.Name = "CodigoCompra";
            this.CodigoCompra.ReadOnly = true;
            this.CodigoCompra.Width = 50;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 120;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // gridCompras
            // 
            this.gridCompras.AllowUserToAddRows = false;
            this.gridCompras.AllowUserToDeleteRows = false;
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.Valor});
            this.gridCompras.Location = new System.Drawing.Point(6, 8);
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.ReadOnly = true;
            this.gridCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCompras.Size = new System.Drawing.Size(486, 426);
            this.gridCompras.TabIndex = 19;
            this.gridCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompras_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 225;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Location = new System.Drawing.Point(689, 411);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Size = new System.Drawing.Size(113, 23);
            this.btnEliminarCompra.TabIndex = 18;
            this.btnEliminarCompra.Text = "Eliminar compra";
            this.btnEliminarCompra.UseVisualStyleBackColor = true;
            this.btnEliminarCompra.Click += new System.EventHandler(this.btnEliminarCompra_Click);
            // 
            // btnAcrescCompra
            // 
            this.btnAcrescCompra.Location = new System.Drawing.Point(688, 379);
            this.btnAcrescCompra.Name = "btnAcrescCompra";
            this.btnAcrescCompra.Size = new System.Drawing.Size(113, 23);
            this.btnAcrescCompra.TabIndex = 17;
            this.btnAcrescCompra.Text = "Acrescentar Compra";
            this.btnAcrescCompra.UseVisualStyleBackColor = true;
            this.btnAcrescCompra.Click += new System.EventHandler(this.btnAcrescCompra_Click);
            // 
            // btnAceitarCompra
            // 
            this.btnAceitarCompra.Location = new System.Drawing.Point(498, 411);
            this.btnAceitarCompra.Name = "btnAceitarCompra";
            this.btnAceitarCompra.Size = new System.Drawing.Size(113, 23);
            this.btnAceitarCompra.TabIndex = 16;
            this.btnAceitarCompra.Text = "Aceitar Alterações";
            this.btnAceitarCompra.UseVisualStyleBackColor = true;
            this.btnAceitarCompra.Click += new System.EventHandler(this.btnAceitarCompra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descrição:";
            // 
            // txtDecricaoCompra
            // 
            this.txtDecricaoCompra.Location = new System.Drawing.Point(562, 353);
            this.txtDecricaoCompra.Name = "txtDecricaoCompra";
            this.txtDecricaoCompra.Size = new System.Drawing.Size(241, 20);
            this.txtDecricaoCompra.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor:";
            // 
            // txtCompraValor
            // 
            this.txtCompraValor.Location = new System.Drawing.Point(737, 302);
            this.txtCompraValor.Name = "txtCompraValor";
            this.txtCompraValor.ReadOnly = true;
            this.txtCompraValor.Size = new System.Drawing.Size(66, 20);
            this.txtCompraValor.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Codigo:";
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.Location = new System.Drawing.Point(562, 302);
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoCompra.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 490);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SuperDume";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArtigos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComprasArtigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAcres;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.DataGridView gridArtigos;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnAcrescentarCliente;
        private System.Windows.Forms.Button txtAlteracoesCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEliminarCompra;
        private System.Windows.Forms.Button btnAcrescCompra;
        private System.Windows.Forms.Button btnAceitarCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDecricaoCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCompraValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigoCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.Button btnCartaoCliente;
        private System.Windows.Forms.DataGridView gridComprasArtigos;
        private System.Windows.Forms.DataGridView gridCompras;
        private System.Windows.Forms.Button btnEliminarArtigoCompra;
        private System.Windows.Forms.ComboBox comboClienteCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboArtigos;
        private System.Windows.Forms.Button btnAcresArtigoCompra;
        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantidadeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}