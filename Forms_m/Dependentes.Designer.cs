namespace projeto_integrado.Forms
{
    partial class Dependentes
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
            this.btn_deletar_dependentes_m = new System.Windows.Forms.Button();
            this.btn_editar_dependentes_m = new System.Windows.Forms.Button();
            this.btn_adicionar_dependentes_m = new System.Windows.Forms.Button();
            this.datagridview_dependentes_m = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dependentes_m)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deletar_dependentes_m
            // 
            this.btn_deletar_dependentes_m.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_deletar_dependentes_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_dependentes_m.Location = new System.Drawing.Point(725, 288);
            this.btn_deletar_dependentes_m.Name = "btn_deletar_dependentes_m";
            this.btn_deletar_dependentes_m.Size = new System.Drawing.Size(97, 42);
            this.btn_deletar_dependentes_m.TabIndex = 14;
            this.btn_deletar_dependentes_m.Text = "Deletar";
            this.btn_deletar_dependentes_m.UseVisualStyleBackColor = true;
            // 
            // btn_editar_dependentes_m
            // 
            this.btn_editar_dependentes_m.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editar_dependentes_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_dependentes_m.Location = new System.Drawing.Point(725, 212);
            this.btn_editar_dependentes_m.Name = "btn_editar_dependentes_m";
            this.btn_editar_dependentes_m.Size = new System.Drawing.Size(97, 42);
            this.btn_editar_dependentes_m.TabIndex = 13;
            this.btn_editar_dependentes_m.Text = "Editar";
            this.btn_editar_dependentes_m.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar_dependentes_m
            // 
            this.btn_adicionar_dependentes_m.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_adicionar_dependentes_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_dependentes_m.Location = new System.Drawing.Point(725, 138);
            this.btn_adicionar_dependentes_m.Name = "btn_adicionar_dependentes_m";
            this.btn_adicionar_dependentes_m.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_dependentes_m.TabIndex = 12;
            this.btn_adicionar_dependentes_m.Text = "Adicionar";
            this.btn_adicionar_dependentes_m.UseVisualStyleBackColor = true;
            // 
            // datagridview_dependentes_m
            // 
            this.datagridview_dependentes_m.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_dependentes_m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_dependentes_m.Location = new System.Drawing.Point(57, 46);
            this.datagridview_dependentes_m.Name = "datagridview_dependentes_m";
            this.datagridview_dependentes_m.RowHeadersWidth = 51;
            this.datagridview_dependentes_m.RowTemplate.Height = 24;
            this.datagridview_dependentes_m.Size = new System.Drawing.Size(642, 369);
            this.datagridview_dependentes_m.TabIndex = 11;
            // 
            // Dependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_deletar_dependentes_m);
            this.Controls.Add(this.btn_editar_dependentes_m);
            this.Controls.Add(this.btn_adicionar_dependentes_m);
            this.Controls.Add(this.datagridview_dependentes_m);
            this.Name = "Dependentes";
            this.Text = "Dependentes";
            this.Load += new System.EventHandler(this.Dependentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dependentes_m)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deletar_dependentes_m;
        private System.Windows.Forms.Button btn_editar_dependentes_m;
        private System.Windows.Forms.Button btn_adicionar_dependentes_m;
        private System.Windows.Forms.DataGridView datagridview_dependentes_m;
    }
}