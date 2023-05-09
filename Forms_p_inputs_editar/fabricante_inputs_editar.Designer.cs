namespace projeto_integrado.Forms_p_inputs_editar
{
    partial class fabricante_inputs_editar
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
            this.checkBox_editar_fabricante_ativo_p = new System.Windows.Forms.CheckBox();
            this.btn_editar_fabricantes_enviar_p = new System.Windows.Forms.Button();
            this.input_editar_fabricante_nome_p = new System.Windows.Forms.TextBox();
            this.lbl_editar_fabricante_nome_p = new System.Windows.Forms.Label();
            this.lbl_editar_fabricante_titulo_inputs_p = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_editar_fabricante_ativo_p
            // 
            this.checkBox_editar_fabricante_ativo_p.AutoSize = true;
            this.checkBox_editar_fabricante_ativo_p.Location = new System.Drawing.Point(372, 174);
            this.checkBox_editar_fabricante_ativo_p.Name = "checkBox_editar_fabricante_ativo_p";
            this.checkBox_editar_fabricante_ativo_p.Size = new System.Drawing.Size(66, 20);
            this.checkBox_editar_fabricante_ativo_p.TabIndex = 106;
            this.checkBox_editar_fabricante_ativo_p.Text = "Ativo?";
            this.checkBox_editar_fabricante_ativo_p.UseVisualStyleBackColor = true;
            // 
            // btn_editar_fabricantes_enviar_p
            // 
            this.btn_editar_fabricantes_enviar_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_editar_fabricantes_enviar_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_fabricantes_enviar_p.Location = new System.Drawing.Point(352, 243);
            this.btn_editar_fabricantes_enviar_p.Name = "btn_editar_fabricantes_enviar_p";
            this.btn_editar_fabricantes_enviar_p.Size = new System.Drawing.Size(109, 33);
            this.btn_editar_fabricantes_enviar_p.TabIndex = 105;
            this.btn_editar_fabricantes_enviar_p.Text = "Editar";
            this.btn_editar_fabricantes_enviar_p.UseVisualStyleBackColor = true;
            // 
            // input_editar_fabricante_nome_p
            // 
            this.input_editar_fabricante_nome_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_editar_fabricante_nome_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_editar_fabricante_nome_p.Location = new System.Drawing.Point(260, 118);
            this.input_editar_fabricante_nome_p.Name = "input_editar_fabricante_nome_p";
            this.input_editar_fabricante_nome_p.Size = new System.Drawing.Size(284, 22);
            this.input_editar_fabricante_nome_p.TabIndex = 104;
            // 
            // lbl_editar_fabricante_nome_p
            // 
            this.lbl_editar_fabricante_nome_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_editar_fabricante_nome_p.AutoSize = true;
            this.lbl_editar_fabricante_nome_p.Location = new System.Drawing.Point(257, 99);
            this.lbl_editar_fabricante_nome_p.Name = "lbl_editar_fabricante_nome_p";
            this.lbl_editar_fabricante_nome_p.Size = new System.Drawing.Size(125, 16);
            this.lbl_editar_fabricante_nome_p.TabIndex = 103;
            this.lbl_editar_fabricante_nome_p.Text = "Nome do fabricante";
            // 
            // lbl_editar_fabricante_titulo_inputs_p
            // 
            this.lbl_editar_fabricante_titulo_inputs_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_editar_fabricante_titulo_inputs_p.AutoSize = true;
            this.lbl_editar_fabricante_titulo_inputs_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editar_fabricante_titulo_inputs_p.Location = new System.Drawing.Point(332, 36);
            this.lbl_editar_fabricante_titulo_inputs_p.Name = "lbl_editar_fabricante_titulo_inputs_p";
            this.lbl_editar_fabricante_titulo_inputs_p.Size = new System.Drawing.Size(145, 29);
            this.lbl_editar_fabricante_titulo_inputs_p.TabIndex = 102;
            this.lbl_editar_fabricante_titulo_inputs_p.Text = "Fabricantes";
            // 
            // fabricante_inputs_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.checkBox_editar_fabricante_ativo_p);
            this.Controls.Add(this.btn_editar_fabricantes_enviar_p);
            this.Controls.Add(this.input_editar_fabricante_nome_p);
            this.Controls.Add(this.lbl_editar_fabricante_nome_p);
            this.Controls.Add(this.lbl_editar_fabricante_titulo_inputs_p);
            this.Name = "fabricante_inputs_editar";
            this.Text = "fabricante_inputs_editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_editar_fabricantes_enviar_p;
        private System.Windows.Forms.Label lbl_editar_fabricante_nome_p;
        private System.Windows.Forms.Label lbl_editar_fabricante_titulo_inputs_p;
        public System.Windows.Forms.CheckBox checkBox_editar_fabricante_ativo_p;
        public System.Windows.Forms.TextBox input_editar_fabricante_nome_p;
    }
}