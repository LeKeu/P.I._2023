﻿namespace projeto_integrado.Forms_p
{
    partial class Setor
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
            this.btn_deletar_setor_p = new System.Windows.Forms.Button();
            this.btn_editar_setor_p = new System.Windows.Forms.Button();
            this.btn_adicionar_setor_p = new System.Windows.Forms.Button();
            this.datagridview_setor_p = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_setor_p)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deletar_setor_p
            // 
            this.btn_deletar_setor_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_deletar_setor_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_setor_p.Location = new System.Drawing.Point(719, 289);
            this.btn_deletar_setor_p.Name = "btn_deletar_setor_p";
            this.btn_deletar_setor_p.Size = new System.Drawing.Size(97, 42);
            this.btn_deletar_setor_p.TabIndex = 26;
            this.btn_deletar_setor_p.Text = "Deletar";
            this.btn_deletar_setor_p.UseVisualStyleBackColor = true;
            // 
            // btn_editar_setor_p
            // 
            this.btn_editar_setor_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editar_setor_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_setor_p.Location = new System.Drawing.Point(719, 213);
            this.btn_editar_setor_p.Name = "btn_editar_setor_p";
            this.btn_editar_setor_p.Size = new System.Drawing.Size(97, 42);
            this.btn_editar_setor_p.TabIndex = 25;
            this.btn_editar_setor_p.Text = "Editar";
            this.btn_editar_setor_p.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar_setor_p
            // 
            this.btn_adicionar_setor_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_adicionar_setor_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_setor_p.Location = new System.Drawing.Point(719, 139);
            this.btn_adicionar_setor_p.Name = "btn_adicionar_setor_p";
            this.btn_adicionar_setor_p.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_setor_p.TabIndex = 24;
            this.btn_adicionar_setor_p.Text = "Adicionar";
            this.btn_adicionar_setor_p.UseVisualStyleBackColor = true;
            this.btn_adicionar_setor_p.Click += new System.EventHandler(this.btn_adicionar_setor_p_Click);
            // 
            // datagridview_setor_p
            // 
            this.datagridview_setor_p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_setor_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_setor_p.Location = new System.Drawing.Point(51, 47);
            this.datagridview_setor_p.Name = "datagridview_setor_p";
            this.datagridview_setor_p.RowHeadersWidth = 51;
            this.datagridview_setor_p.RowTemplate.Height = 24;
            this.datagridview_setor_p.Size = new System.Drawing.Size(642, 369);
            this.datagridview_setor_p.TabIndex = 23;
            // 
            // Setor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_deletar_setor_p);
            this.Controls.Add(this.btn_editar_setor_p);
            this.Controls.Add(this.btn_adicionar_setor_p);
            this.Controls.Add(this.datagridview_setor_p);
            this.Name = "Setor";
            this.Text = "Setor";
            this.Load += new System.EventHandler(this.Setor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_setor_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deletar_setor_p;
        private System.Windows.Forms.Button btn_editar_setor_p;
        private System.Windows.Forms.Button btn_adicionar_setor_p;
        private System.Windows.Forms.DataGridView datagridview_setor_p;
    }
}