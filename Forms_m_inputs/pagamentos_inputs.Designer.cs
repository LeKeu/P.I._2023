namespace projeto_integrado.Forms_m_inputs
{
    partial class pagamentos_inputs
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
            this.lbl_pagamento_titulo_inputs_m = new System.Windows.Forms.Label();
            this.input_pagamento_valor_m = new System.Windows.Forms.TextBox();
            this.lbl_pagamento_valor_m = new System.Windows.Forms.Label();
            this.input_pagamento_nome_m = new System.Windows.Forms.TextBox();
            this.lbl_pagamento_nome_m = new System.Windows.Forms.Label();
            this.btn_pagamentos_enviar_m = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pagamento_titulo_inputs_m
            // 
            this.lbl_pagamento_titulo_inputs_m.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pagamento_titulo_inputs_m.AutoSize = true;
            this.lbl_pagamento_titulo_inputs_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagamento_titulo_inputs_m.Location = new System.Drawing.Point(320, 27);
            this.lbl_pagamento_titulo_inputs_m.Name = "lbl_pagamento_titulo_inputs_m";
            this.lbl_pagamento_titulo_inputs_m.Size = new System.Drawing.Size(156, 29);
            this.lbl_pagamento_titulo_inputs_m.TabIndex = 39;
            this.lbl_pagamento_titulo_inputs_m.Text = "Pagamentos";
            // 
            // input_pagamento_valor_m
            // 
            this.input_pagamento_valor_m.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_pagamento_valor_m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_pagamento_valor_m.Location = new System.Drawing.Point(425, 102);
            this.input_pagamento_valor_m.Name = "input_pagamento_valor_m";
            this.input_pagamento_valor_m.Size = new System.Drawing.Size(284, 22);
            this.input_pagamento_valor_m.TabIndex = 43;
            // 
            // lbl_pagamento_valor_m
            // 
            this.lbl_pagamento_valor_m.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pagamento_valor_m.AutoSize = true;
            this.lbl_pagamento_valor_m.Location = new System.Drawing.Point(422, 83);
            this.lbl_pagamento_valor_m.Name = "lbl_pagamento_valor_m";
            this.lbl_pagamento_valor_m.Size = new System.Drawing.Size(74, 16);
            this.lbl_pagamento_valor_m.TabIndex = 42;
            this.lbl_pagamento_valor_m.Text = "Valor pago";
            // 
            // input_pagamento_nome_m
            // 
            this.input_pagamento_nome_m.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_pagamento_nome_m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_pagamento_nome_m.Location = new System.Drawing.Point(97, 102);
            this.input_pagamento_nome_m.Name = "input_pagamento_nome_m";
            this.input_pagamento_nome_m.Size = new System.Drawing.Size(284, 22);
            this.input_pagamento_nome_m.TabIndex = 41;
            // 
            // lbl_pagamento_nome_m
            // 
            this.lbl_pagamento_nome_m.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pagamento_nome_m.AutoSize = true;
            this.lbl_pagamento_nome_m.Location = new System.Drawing.Point(94, 83);
            this.lbl_pagamento_nome_m.Name = "lbl_pagamento_nome_m";
            this.lbl_pagamento_nome_m.Size = new System.Drawing.Size(44, 16);
            this.lbl_pagamento_nome_m.TabIndex = 40;
            this.lbl_pagamento_nome_m.Text = "Nome";
            // 
            // btn_pagamentos_enviar_m
            // 
            this.btn_pagamentos_enviar_m.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pagamentos_enviar_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagamentos_enviar_m.Location = new System.Drawing.Point(348, 164);
            this.btn_pagamentos_enviar_m.Name = "btn_pagamentos_enviar_m";
            this.btn_pagamentos_enviar_m.Size = new System.Drawing.Size(109, 33);
            this.btn_pagamentos_enviar_m.TabIndex = 44;
            this.btn_pagamentos_enviar_m.Text = "Enviar";
            this.btn_pagamentos_enviar_m.UseVisualStyleBackColor = true;
            this.btn_pagamentos_enviar_m.Click += new System.EventHandler(this.btn_pagamentos_enviar_m_Click);
            // 
            // pagamentos_inputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.btn_pagamentos_enviar_m);
            this.Controls.Add(this.input_pagamento_valor_m);
            this.Controls.Add(this.lbl_pagamento_valor_m);
            this.Controls.Add(this.input_pagamento_nome_m);
            this.Controls.Add(this.lbl_pagamento_nome_m);
            this.Controls.Add(this.lbl_pagamento_titulo_inputs_m);
            this.Name = "pagamentos_inputs";
            this.Text = "pagamentos_inputs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pagamento_titulo_inputs_m;
        private System.Windows.Forms.TextBox input_pagamento_valor_m;
        private System.Windows.Forms.Label lbl_pagamento_valor_m;
        private System.Windows.Forms.TextBox input_pagamento_nome_m;
        private System.Windows.Forms.Label lbl_pagamento_nome_m;
        private System.Windows.Forms.Button btn_pagamentos_enviar_m;
    }
}