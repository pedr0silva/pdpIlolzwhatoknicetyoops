namespace LojaUI
{
    partial class Cartao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gridCartao = new System.Windows.Forms.DataGridView();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCartao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(295, 245);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(82, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gridCartao
            // 
            this.gridCartao.AllowUserToAddRows = false;
            this.gridCartao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCartao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCartao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCartao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCartao,
            this.ValorCartao,
            this.DescricaoCartao});
            this.gridCartao.Location = new System.Drawing.Point(12, 12);
            this.gridCartao.Name = "gridCartao";
            this.gridCartao.ReadOnly = true;
            this.gridCartao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCartao.Size = new System.Drawing.Size(377, 224);
            this.gridCartao.TabIndex = 6;
            // 
            // txtPontos
            // 
            this.txtPontos.Location = new System.Drawing.Point(64, 247);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.ReadOnly = true;
            this.txtPontos.Size = new System.Drawing.Size(44, 20);
            this.txtPontos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pontos: ";
            // 
            // CodigoCartao
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodigoCartao.DefaultCellStyle = dataGridViewCellStyle6;
            this.CodigoCartao.HeaderText = "Codigo";
            this.CodigoCartao.Name = "CodigoCartao";
            this.CodigoCartao.ReadOnly = true;
            // 
            // ValorCartao
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ValorCartao.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValorCartao.HeaderText = "Valor";
            this.ValorCartao.Name = "ValorCartao";
            this.ValorCartao.ReadOnly = true;
            this.ValorCartao.Width = 80;
            // 
            // DescricaoCartao
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescricaoCartao.DefaultCellStyle = dataGridViewCellStyle8;
            this.DescricaoCartao.HeaderText = "Descricao";
            this.DescricaoCartao.Name = "DescricaoCartao";
            this.DescricaoCartao.ReadOnly = true;
            this.DescricaoCartao.Width = 150;
            // 
            // Cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridCartao);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartao";
            ((System.ComponentModel.ISupportInitialize)(this.gridCartao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView gridCartao;
        private System.Windows.Forms.TextBox txtPontos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCartao;
    }
}