﻿namespace projeto_integrado.Forms_p
{
    partial class Produto
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
            this.components = new System.ComponentModel.Container();
            this.btn_adicionar_produto_p = new System.Windows.Forms.Button();
            this.datagridview_produto_p = new System.Windows.Forms.DataGridView();
            this.btn_invisivel_produto_p = new System.Windows.Forms.Button();
            this.timer_produto_p = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_produto_p)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adicionar_produto_p
            // 
            this.btn_adicionar_produto_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_adicionar_produto_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_produto_p.Location = new System.Drawing.Point(720, 383);
            this.btn_adicionar_produto_p.Name = "btn_adicionar_produto_p";
            this.btn_adicionar_produto_p.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_produto_p.TabIndex = 20;
            this.btn_adicionar_produto_p.Text = "Adicionar";
            this.btn_adicionar_produto_p.UseVisualStyleBackColor = true;
            this.btn_adicionar_produto_p.Click += new System.EventHandler(this.btn_adicionar_produto_p_Click);
            // 
            // datagridview_produto_p
            // 
            this.datagridview_produto_p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_produto_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_produto_p.Location = new System.Drawing.Point(52, 56);
            this.datagridview_produto_p.Name = "datagridview_produto_p";
            this.datagridview_produto_p.RowHeadersWidth = 51;
            this.datagridview_produto_p.RowTemplate.Height = 24;
            this.datagridview_produto_p.Size = new System.Drawing.Size(642, 369);
            this.datagridview_produto_p.TabIndex = 19;
            this.datagridview_produto_p.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_produto_p_CellDoubleClick);
            // 
            // btn_invisivel_produto_p
            // 
            this.btn_invisivel_produto_p.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_invisivel_produto_p.Location = new System.Drawing.Point(52, 402);
            this.btn_invisivel_produto_p.Name = "btn_invisivel_produto_p";
            this.btn_invisivel_produto_p.Size = new System.Drawing.Size(75, 23);
            this.btn_invisivel_produto_p.TabIndex = 23;
            this.btn_invisivel_produto_p.Text = "button1";
            this.btn_invisivel_produto_p.UseVisualStyleBackColor = true;
            this.btn_invisivel_produto_p.Click += new System.EventHandler(this.btn_invisivel_produto_p_Click);
            // 
            // timer_produto_p
            // 
            this.timer_produto_p.Interval = 5000;
            this.timer_produto_p.Tick += new System.EventHandler(this.timer_produto_p_Tick);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_adicionar_produto_p);
            this.Controls.Add(this.datagridview_produto_p);
            this.Controls.Add(this.btn_invisivel_produto_p);
            this.Name = "Produto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_produto_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_adicionar_produto_p;
        private System.Windows.Forms.DataGridView datagridview_produto_p;
        private System.Windows.Forms.Button btn_invisivel_produto_p;
        private System.Windows.Forms.Timer timer_produto_p;
    }
}