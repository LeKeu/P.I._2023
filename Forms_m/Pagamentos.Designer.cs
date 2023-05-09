namespace projeto_integrado.Forms
{
    partial class Pagamentos
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
            this.btn_deletar_pagamentos_m = new System.Windows.Forms.Button();
            this.btn_editar_pagamentos_m = new System.Windows.Forms.Button();
            this.btn_adicionar_pagamentos_m = new System.Windows.Forms.Button();
            this.datagridview_pagamentos_m = new System.Windows.Forms.DataGridView();
            this.btn_invisivel_memListPag_m = new System.Windows.Forms.Button();
            this.timer_listaPag_m = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_pagamentos_m)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deletar_pagamentos_m
            // 
            this.btn_deletar_pagamentos_m.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_deletar_pagamentos_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_pagamentos_m.Location = new System.Drawing.Point(729, 288);
            this.btn_deletar_pagamentos_m.Name = "btn_deletar_pagamentos_m";
            this.btn_deletar_pagamentos_m.Size = new System.Drawing.Size(97, 42);
            this.btn_deletar_pagamentos_m.TabIndex = 19;
            this.btn_deletar_pagamentos_m.Text = "Deletar";
            this.btn_deletar_pagamentos_m.UseVisualStyleBackColor = true;
            // 
            // btn_editar_pagamentos_m
            // 
            this.btn_editar_pagamentos_m.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editar_pagamentos_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_pagamentos_m.Location = new System.Drawing.Point(729, 212);
            this.btn_editar_pagamentos_m.Name = "btn_editar_pagamentos_m";
            this.btn_editar_pagamentos_m.Size = new System.Drawing.Size(97, 42);
            this.btn_editar_pagamentos_m.TabIndex = 18;
            this.btn_editar_pagamentos_m.Text = "Editar";
            this.btn_editar_pagamentos_m.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar_pagamentos_m
            // 
            this.btn_adicionar_pagamentos_m.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_adicionar_pagamentos_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_pagamentos_m.Location = new System.Drawing.Point(729, 138);
            this.btn_adicionar_pagamentos_m.Name = "btn_adicionar_pagamentos_m";
            this.btn_adicionar_pagamentos_m.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_pagamentos_m.TabIndex = 17;
            this.btn_adicionar_pagamentos_m.Text = "Adicionar";
            this.btn_adicionar_pagamentos_m.UseVisualStyleBackColor = true;
            this.btn_adicionar_pagamentos_m.Click += new System.EventHandler(this.btn_adicionar_pagamentos_m_Click);
            // 
            // datagridview_pagamentos_m
            // 
            this.datagridview_pagamentos_m.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_pagamentos_m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_pagamentos_m.Location = new System.Drawing.Point(57, 51);
            this.datagridview_pagamentos_m.Name = "datagridview_pagamentos_m";
            this.datagridview_pagamentos_m.RowHeadersWidth = 51;
            this.datagridview_pagamentos_m.RowTemplate.Height = 24;
            this.datagridview_pagamentos_m.Size = new System.Drawing.Size(642, 369);
            this.datagridview_pagamentos_m.TabIndex = 16;
            this.datagridview_pagamentos_m.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_pagamentos_m_CellDoubleClick);
            // 
            // btn_invisivel_memListPag_m
            // 
            this.btn_invisivel_memListPag_m.Location = new System.Drawing.Point(272, 426);
            this.btn_invisivel_memListPag_m.Name = "btn_invisivel_memListPag_m";
            this.btn_invisivel_memListPag_m.Size = new System.Drawing.Size(75, 23);
            this.btn_invisivel_memListPag_m.TabIndex = 20;
            this.btn_invisivel_memListPag_m.Text = "button1";
            this.btn_invisivel_memListPag_m.UseVisualStyleBackColor = true;
            this.btn_invisivel_memListPag_m.Click += new System.EventHandler(this.btn_invisivel_memListPag_m_Click);
            // 
            // timer_listaPag_m
            // 
            this.timer_listaPag_m.Interval = 5000;
            this.timer_listaPag_m.Tick += new System.EventHandler(this.timer_listaPag_m_Tick);
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_invisivel_memListPag_m);
            this.Controls.Add(this.btn_deletar_pagamentos_m);
            this.Controls.Add(this.btn_editar_pagamentos_m);
            this.Controls.Add(this.btn_adicionar_pagamentos_m);
            this.Controls.Add(this.datagridview_pagamentos_m);
            this.Name = "Pagamentos";
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.Pagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_pagamentos_m)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deletar_pagamentos_m;
        private System.Windows.Forms.Button btn_editar_pagamentos_m;
        private System.Windows.Forms.Button btn_adicionar_pagamentos_m;
        private System.Windows.Forms.DataGridView datagridview_pagamentos_m;
        private System.Windows.Forms.Button btn_invisivel_memListPag_m;
        private System.Windows.Forms.Timer timer_listaPag_m;
    }
}