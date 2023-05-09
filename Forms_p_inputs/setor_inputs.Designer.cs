namespace projeto_integrado.Forms_p_inputs
{
    partial class setor_inputs
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
            this.btn_setor_enviar_p = new System.Windows.Forms.Button();
            this.input_setor_nome_p = new System.Windows.Forms.TextBox();
            this.lbl_setor_nome_p = new System.Windows.Forms.Label();
            this.lbl_setor_titulo_inputs_p = new System.Windows.Forms.Label();
            this.checkBox_setor_ativo_p = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_setor_enviar_p
            // 
            this.btn_setor_enviar_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_setor_enviar_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setor_enviar_p.Location = new System.Drawing.Point(348, 216);
            this.btn_setor_enviar_p.Name = "btn_setor_enviar_p";
            this.btn_setor_enviar_p.Size = new System.Drawing.Size(109, 33);
            this.btn_setor_enviar_p.TabIndex = 106;
            this.btn_setor_enviar_p.Text = "Enviar";
            this.btn_setor_enviar_p.UseVisualStyleBackColor = true;
            this.btn_setor_enviar_p.Click += new System.EventHandler(this.btn_setor_enviar_p_Click);
            // 
            // input_setor_nome_p
            // 
            this.input_setor_nome_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_setor_nome_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_setor_nome_p.Location = new System.Drawing.Point(259, 105);
            this.input_setor_nome_p.Name = "input_setor_nome_p";
            this.input_setor_nome_p.Size = new System.Drawing.Size(284, 22);
            this.input_setor_nome_p.TabIndex = 103;
            // 
            // lbl_setor_nome_p
            // 
            this.lbl_setor_nome_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_setor_nome_p.AutoSize = true;
            this.lbl_setor_nome_p.Location = new System.Drawing.Point(256, 86);
            this.lbl_setor_nome_p.Name = "lbl_setor_nome_p";
            this.lbl_setor_nome_p.Size = new System.Drawing.Size(96, 16);
            this.lbl_setor_nome_p.TabIndex = 102;
            this.lbl_setor_nome_p.Text = "Nome do setor";
            // 
            // lbl_setor_titulo_inputs_p
            // 
            this.lbl_setor_titulo_inputs_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_setor_titulo_inputs_p.AutoSize = true;
            this.lbl_setor_titulo_inputs_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setor_titulo_inputs_p.Location = new System.Drawing.Point(368, 41);
            this.lbl_setor_titulo_inputs_p.Name = "lbl_setor_titulo_inputs_p";
            this.lbl_setor_titulo_inputs_p.Size = new System.Drawing.Size(73, 29);
            this.lbl_setor_titulo_inputs_p.TabIndex = 101;
            this.lbl_setor_titulo_inputs_p.Text = "Setor";
            // 
            // checkBox_setor_ativo_p
            // 
            this.checkBox_setor_ativo_p.AutoSize = true;
            this.checkBox_setor_ativo_p.Location = new System.Drawing.Point(369, 162);
            this.checkBox_setor_ativo_p.Name = "checkBox_setor_ativo_p";
            this.checkBox_setor_ativo_p.Size = new System.Drawing.Size(66, 20);
            this.checkBox_setor_ativo_p.TabIndex = 107;
            this.checkBox_setor_ativo_p.Text = "Ativo?";
            this.checkBox_setor_ativo_p.UseVisualStyleBackColor = true;
            // 
            // setor_inputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.checkBox_setor_ativo_p);
            this.Controls.Add(this.btn_setor_enviar_p);
            this.Controls.Add(this.input_setor_nome_p);
            this.Controls.Add(this.lbl_setor_nome_p);
            this.Controls.Add(this.lbl_setor_titulo_inputs_p);
            this.Name = "setor_inputs";
            this.Text = "setor_inputs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_setor_enviar_p;
        private System.Windows.Forms.Label lbl_setor_nome_p;
        private System.Windows.Forms.Label lbl_setor_titulo_inputs_p;
        public System.Windows.Forms.TextBox input_setor_nome_p;
        public System.Windows.Forms.CheckBox checkBox_setor_ativo_p;
    }
}