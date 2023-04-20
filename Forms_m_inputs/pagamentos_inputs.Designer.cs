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
            this.SuspendLayout();
            // 
            // lbl_pagamento_titulo_inputs_m
            // 
            this.lbl_pagamento_titulo_inputs_m.AutoSize = true;
            this.lbl_pagamento_titulo_inputs_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagamento_titulo_inputs_m.Location = new System.Drawing.Point(339, 18);
            this.lbl_pagamento_titulo_inputs_m.Name = "lbl_pagamento_titulo_inputs_m";
            this.lbl_pagamento_titulo_inputs_m.Size = new System.Drawing.Size(156, 29);
            this.lbl_pagamento_titulo_inputs_m.TabIndex = 39;
            this.lbl_pagamento_titulo_inputs_m.Text = "Pagamentos";
            // 
            // pagamentos_inputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lbl_pagamento_titulo_inputs_m);
            this.Name = "pagamentos_inputs";
            this.Text = "pagamentos_inputs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pagamento_titulo_inputs_m;
    }
}