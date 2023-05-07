namespace projeto_integrado.Forms_p_inputs
{
    partial class fabricante_inputs
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
            this.btn_fabricantes_enviar_p = new System.Windows.Forms.Button();
            this.input_fabricante_nome_p = new System.Windows.Forms.TextBox();
            this.lbl_fabricante_nome_p = new System.Windows.Forms.Label();
            this.lbl_fabricante_titulo_inputs_p = new System.Windows.Forms.Label();
            this.checkBox_fabricante_ativo_p = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_fabricantes_enviar_p
            // 
            this.btn_fabricantes_enviar_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fabricantes_enviar_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fabricantes_enviar_p.Location = new System.Drawing.Point(355, 229);
            this.btn_fabricantes_enviar_p.Name = "btn_fabricantes_enviar_p";
            this.btn_fabricantes_enviar_p.Size = new System.Drawing.Size(109, 33);
            this.btn_fabricantes_enviar_p.TabIndex = 100;
            this.btn_fabricantes_enviar_p.Text = "Enviar";
            this.btn_fabricantes_enviar_p.UseVisualStyleBackColor = true;
            this.btn_fabricantes_enviar_p.Click += new System.EventHandler(this.btn_fabricantes_enviar_p_Click);
            // 
            // input_fabricante_nome_p
            // 
            this.input_fabricante_nome_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_fabricante_nome_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_fabricante_nome_p.Location = new System.Drawing.Point(263, 104);
            this.input_fabricante_nome_p.Name = "input_fabricante_nome_p";
            this.input_fabricante_nome_p.Size = new System.Drawing.Size(284, 22);
            this.input_fabricante_nome_p.TabIndex = 79;
            // 
            // lbl_fabricante_nome_p
            // 
            this.lbl_fabricante_nome_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fabricante_nome_p.AutoSize = true;
            this.lbl_fabricante_nome_p.Location = new System.Drawing.Point(260, 85);
            this.lbl_fabricante_nome_p.Name = "lbl_fabricante_nome_p";
            this.lbl_fabricante_nome_p.Size = new System.Drawing.Size(125, 16);
            this.lbl_fabricante_nome_p.TabIndex = 78;
            this.lbl_fabricante_nome_p.Text = "Nome do fabricante";
            // 
            // lbl_fabricante_titulo_inputs_p
            // 
            this.lbl_fabricante_titulo_inputs_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fabricante_titulo_inputs_p.AutoSize = true;
            this.lbl_fabricante_titulo_inputs_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fabricante_titulo_inputs_p.Location = new System.Drawing.Point(335, 22);
            this.lbl_fabricante_titulo_inputs_p.Name = "lbl_fabricante_titulo_inputs_p";
            this.lbl_fabricante_titulo_inputs_p.Size = new System.Drawing.Size(145, 29);
            this.lbl_fabricante_titulo_inputs_p.TabIndex = 77;
            this.lbl_fabricante_titulo_inputs_p.Text = "Fabricantes";
            // 
            // checkBox_fabricante_ativo_p
            // 
            this.checkBox_fabricante_ativo_p.AutoSize = true;
            this.checkBox_fabricante_ativo_p.Location = new System.Drawing.Point(375, 160);
            this.checkBox_fabricante_ativo_p.Name = "checkBox_fabricante_ativo_p";
            this.checkBox_fabricante_ativo_p.Size = new System.Drawing.Size(66, 20);
            this.checkBox_fabricante_ativo_p.TabIndex = 101;
            this.checkBox_fabricante_ativo_p.Text = "Ativo?";
            this.checkBox_fabricante_ativo_p.UseVisualStyleBackColor = true;
            // 
            // fabricante_inputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.checkBox_fabricante_ativo_p);
            this.Controls.Add(this.btn_fabricantes_enviar_p);
            this.Controls.Add(this.input_fabricante_nome_p);
            this.Controls.Add(this.lbl_fabricante_nome_p);
            this.Controls.Add(this.lbl_fabricante_titulo_inputs_p);
            this.Name = "fabricante_inputs";
            this.Text = "fabricante_inputs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fabricantes_enviar_p;
        private System.Windows.Forms.TextBox input_fabricante_nome_p;
        private System.Windows.Forms.Label lbl_fabricante_nome_p;
        private System.Windows.Forms.Label lbl_fabricante_titulo_inputs_p;
        private System.Windows.Forms.CheckBox checkBox_fabricante_ativo_p;
    }
}