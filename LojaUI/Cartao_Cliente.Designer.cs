﻿namespace LojaUI
{
    partial class Cartao_Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.gridCartao = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCartao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos: ";
            // 
            // txtPontos
            // 
            this.txtPontos.Location = new System.Drawing.Point(64, 247);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.ReadOnly = true;
            this.txtPontos.Size = new System.Drawing.Size(44, 20);
            this.txtPontos.TabIndex = 1;
            // 
            // gridCartao
            // 
            this.gridCartao.AllowUserToAddRows = false;
            this.gridCartao.AllowUserToDeleteRows = false;
            this.gridCartao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCartao.Location = new System.Drawing.Point(12, 12);
            this.gridCartao.Name = "gridCartao";
            this.gridCartao.ReadOnly = true;
            this.gridCartao.Size = new System.Drawing.Size(377, 224);
            this.gridCartao.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(308, 245);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(82, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // Cartao_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 282);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridCartao);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.label1);
            this.Name = "Cartao_Cliente";
            this.Text = "Cartao_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.gridCartao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPontos;
        private System.Windows.Forms.DataGridView gridCartao;
        private System.Windows.Forms.Button btnConfirmar;
    }
}