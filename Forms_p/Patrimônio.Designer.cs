﻿namespace projeto_integrado.Forms_p
{
    partial class Patrimônio
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
            this.btn_adicionar_patrimonio_p = new System.Windows.Forms.Button();
            this.datagridview_patrimonio_p = new System.Windows.Forms.DataGridView();
            this.btn_invisivel_patrimonio_m = new System.Windows.Forms.Button();
            this.timer_patrimonio_p = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_patrimonio_p)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adicionar_patrimonio_p
            // 
            this.btn_adicionar_patrimonio_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_adicionar_patrimonio_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_patrimonio_p.Location = new System.Drawing.Point(723, 381);
            this.btn_adicionar_patrimonio_p.Name = "btn_adicionar_patrimonio_p";
            this.btn_adicionar_patrimonio_p.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_patrimonio_p.TabIndex = 16;
            this.btn_adicionar_patrimonio_p.Text = "Adicionar";
            this.btn_adicionar_patrimonio_p.UseVisualStyleBackColor = true;
            this.btn_adicionar_patrimonio_p.Click += new System.EventHandler(this.btn_adicionar_patrimonio_p_Click);
            // 
            // datagridview_patrimonio_p
            // 
            this.datagridview_patrimonio_p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_patrimonio_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_patrimonio_p.Location = new System.Drawing.Point(55, 54);
            this.datagridview_patrimonio_p.Name = "datagridview_patrimonio_p";
            this.datagridview_patrimonio_p.RowHeadersWidth = 51;
            this.datagridview_patrimonio_p.RowTemplate.Height = 24;
            this.datagridview_patrimonio_p.Size = new System.Drawing.Size(642, 369);
            this.datagridview_patrimonio_p.TabIndex = 15;
            this.datagridview_patrimonio_p.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_patrimonio_p_CellDoubleClick);
            // 
            // btn_invisivel_patrimonio_m
            // 
            this.btn_invisivel_patrimonio_m.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_invisivel_patrimonio_m.Location = new System.Drawing.Point(55, 400);
            this.btn_invisivel_patrimonio_m.Name = "btn_invisivel_patrimonio_m";
            this.btn_invisivel_patrimonio_m.Size = new System.Drawing.Size(75, 23);
            this.btn_invisivel_patrimonio_m.TabIndex = 19;
            this.btn_invisivel_patrimonio_m.Text = "button1";
            this.btn_invisivel_patrimonio_m.UseVisualStyleBackColor = true;
            this.btn_invisivel_patrimonio_m.Click += new System.EventHandler(this.btn_invisivel_patrimonio_m_Click);
            // 
            // timer_patrimonio_p
            // 
            this.timer_patrimonio_p.Interval = 5000;
            this.timer_patrimonio_p.Tick += new System.EventHandler(this.timer_patrimonio_p_Tick);
            // 
            // Patrimônio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_adicionar_patrimonio_p);
            this.Controls.Add(this.datagridview_patrimonio_p);
            this.Controls.Add(this.btn_invisivel_patrimonio_m);
            this.Name = "Patrimônio";
            this.Text = "Patrimônio";
            this.Load += new System.EventHandler(this.Patrimônio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_patrimonio_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_adicionar_patrimonio_p;
        private System.Windows.Forms.DataGridView datagridview_patrimonio_p;
        private System.Windows.Forms.Button btn_invisivel_patrimonio_m;
        private System.Windows.Forms.Timer timer_patrimonio_p;
    }
}