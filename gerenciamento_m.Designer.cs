namespace projeto_integrado
{
    partial class gerenciamento_m
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_lateral = new System.Windows.Forms.Panel();
            this.pagamento_m = new System.Windows.Forms.Button();
            this.dependente_m = new System.Windows.Forms.Button();
            this.principal_m = new System.Windows.Forms.Button();
            this.painel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.painel_titulo = new System.Windows.Forms.Panel();
            this.btn_minimizar_m = new System.Windows.Forms.Button();
            this.btn_maximizar_m = new System.Windows.Forms.Button();
            this.btn_fechar_m = new System.Windows.Forms.Button();
            this.btn_fechar_forms_filho_m = new System.Windows.Forms.Button();
            this.label_titulo_m = new System.Windows.Forms.Label();
            this.painel_principal_m = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_lateral.SuspendLayout();
            this.painel_logo.SuspendLayout();
            this.painel_titulo.SuspendLayout();
            this.painel_principal_m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_lateral
            // 
            this.menu_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.menu_lateral.Controls.Add(this.pagamento_m);
            this.menu_lateral.Controls.Add(this.dependente_m);
            this.menu_lateral.Controls.Add(this.principal_m);
            this.menu_lateral.Controls.Add(this.painel_logo);
            this.menu_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_lateral.Location = new System.Drawing.Point(0, 0);
            this.menu_lateral.Name = "menu_lateral";
            this.menu_lateral.Size = new System.Drawing.Size(246, 581);
            this.menu_lateral.TabIndex = 0;
            // 
            // pagamento_m
            // 
            this.pagamento_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pagamento_m.Dock = System.Windows.Forms.DockStyle.Top;
            this.pagamento_m.FlatAppearance.BorderSize = 0;
            this.pagamento_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagamento_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagamento_m.ForeColor = System.Drawing.Color.Gainsboro;
            this.pagamento_m.Image = global::projeto_integrado.Properties.Resources.dollar;
            this.pagamento_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagamento_m.Location = new System.Drawing.Point(0, 200);
            this.pagamento_m.Name = "pagamento_m";
            this.pagamento_m.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pagamento_m.Size = new System.Drawing.Size(246, 60);
            this.pagamento_m.TabIndex = 3;
            this.pagamento_m.Text = "    Pagamento";
            this.pagamento_m.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagamento_m.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pagamento_m.UseVisualStyleBackColor = false;
            this.pagamento_m.Click += new System.EventHandler(this.pagamento_m_Click);
            // 
            // dependente_m
            // 
            this.dependente_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dependente_m.Dock = System.Windows.Forms.DockStyle.Top;
            this.dependente_m.FlatAppearance.BorderSize = 0;
            this.dependente_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dependente_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependente_m.ForeColor = System.Drawing.Color.Gainsboro;
            this.dependente_m.Image = global::projeto_integrado.Properties.Resources.people;
            this.dependente_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dependente_m.Location = new System.Drawing.Point(0, 140);
            this.dependente_m.Name = "dependente_m";
            this.dependente_m.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.dependente_m.Size = new System.Drawing.Size(246, 60);
            this.dependente_m.TabIndex = 2;
            this.dependente_m.Text = "    Dependentes";
            this.dependente_m.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dependente_m.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dependente_m.UseVisualStyleBackColor = false;
            this.dependente_m.Click += new System.EventHandler(this.dependente_m_Click);
            // 
            // principal_m
            // 
            this.principal_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.principal_m.Dock = System.Windows.Forms.DockStyle.Top;
            this.principal_m.FlatAppearance.BorderSize = 0;
            this.principal_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.principal_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principal_m.ForeColor = System.Drawing.Color.Gainsboro;
            this.principal_m.Image = global::projeto_integrado.Properties.Resources.user__2_;
            this.principal_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.principal_m.Location = new System.Drawing.Point(0, 80);
            this.principal_m.Name = "principal_m";
            this.principal_m.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.principal_m.Size = new System.Drawing.Size(246, 60);
            this.principal_m.TabIndex = 1;
            this.principal_m.Text = "    Membros";
            this.principal_m.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.principal_m.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.principal_m.UseVisualStyleBackColor = false;
            this.principal_m.Click += new System.EventHandler(this.principal_m_Click);
            // 
            // painel_logo
            // 
            this.painel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.painel_logo.Controls.Add(this.label1);
            this.painel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_logo.Location = new System.Drawing.Point(0, 0);
            this.painel_logo.Name = "painel_logo";
            this.painel_logo.Size = new System.Drawing.Size(246, 80);
            this.painel_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projeto Integrado";
            // 
            // painel_titulo
            // 
            this.painel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.painel_titulo.Controls.Add(this.btn_minimizar_m);
            this.painel_titulo.Controls.Add(this.btn_maximizar_m);
            this.painel_titulo.Controls.Add(this.btn_fechar_m);
            this.painel_titulo.Controls.Add(this.btn_fechar_forms_filho_m);
            this.painel_titulo.Controls.Add(this.label_titulo_m);
            this.painel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_titulo.Location = new System.Drawing.Point(246, 0);
            this.painel_titulo.Name = "painel_titulo";
            this.painel_titulo.Size = new System.Drawing.Size(860, 80);
            this.painel_titulo.TabIndex = 1;
            this.painel_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painel_titulo_MouseDown);
            // 
            // btn_minimizar_m
            // 
            this.btn_minimizar_m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar_m.FlatAppearance.BorderSize = 0;
            this.btn_minimizar_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar_m.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar_m.Location = new System.Drawing.Point(766, 0);
            this.btn_minimizar_m.Name = "btn_minimizar_m";
            this.btn_minimizar_m.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar_m.TabIndex = 4;
            this.btn_minimizar_m.Text = "-";
            this.btn_minimizar_m.UseVisualStyleBackColor = true;
            this.btn_minimizar_m.Click += new System.EventHandler(this.btn_minimizar_m_Click);
            // 
            // btn_maximizar_m
            // 
            this.btn_maximizar_m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar_m.FlatAppearance.BorderSize = 0;
            this.btn_maximizar_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximizar_m.ForeColor = System.Drawing.Color.White;
            this.btn_maximizar_m.Location = new System.Drawing.Point(797, 0);
            this.btn_maximizar_m.Name = "btn_maximizar_m";
            this.btn_maximizar_m.Size = new System.Drawing.Size(30, 30);
            this.btn_maximizar_m.TabIndex = 3;
            this.btn_maximizar_m.Text = "O";
            this.btn_maximizar_m.UseVisualStyleBackColor = true;
            this.btn_maximizar_m.Click += new System.EventHandler(this.btn_maximizar_m_Click);
            // 
            // btn_fechar_m
            // 
            this.btn_fechar_m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar_m.FlatAppearance.BorderSize = 0;
            this.btn_fechar_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar_m.ForeColor = System.Drawing.Color.White;
            this.btn_fechar_m.Location = new System.Drawing.Point(827, 0);
            this.btn_fechar_m.Name = "btn_fechar_m";
            this.btn_fechar_m.Size = new System.Drawing.Size(30, 30);
            this.btn_fechar_m.TabIndex = 2;
            this.btn_fechar_m.Text = "X";
            this.btn_fechar_m.UseVisualStyleBackColor = true;
            this.btn_fechar_m.Click += new System.EventHandler(this.btn_fechar_m_Click);
            // 
            // btn_fechar_forms_filho_m
            // 
            this.btn_fechar_forms_filho_m.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_fechar_forms_filho_m.FlatAppearance.BorderSize = 0;
            this.btn_fechar_forms_filho_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_forms_filho_m.Image = global::projeto_integrado.Properties.Resources.close__1_;
            this.btn_fechar_forms_filho_m.Location = new System.Drawing.Point(0, 0);
            this.btn_fechar_forms_filho_m.Name = "btn_fechar_forms_filho_m";
            this.btn_fechar_forms_filho_m.Size = new System.Drawing.Size(75, 80);
            this.btn_fechar_forms_filho_m.TabIndex = 1;
            this.btn_fechar_forms_filho_m.UseVisualStyleBackColor = true;
            this.btn_fechar_forms_filho_m.Click += new System.EventHandler(this.btn_fechar_forms_filho_m_Click);
            // 
            // label_titulo_m
            // 
            this.label_titulo_m.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_titulo_m.AutoSize = true;
            this.label_titulo_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_m.ForeColor = System.Drawing.Color.White;
            this.label_titulo_m.Location = new System.Drawing.Point(396, 25);
            this.label_titulo_m.Name = "label_titulo_m";
            this.label_titulo_m.Size = new System.Drawing.Size(95, 31);
            this.label_titulo_m.TabIndex = 0;
            this.label_titulo_m.Text = "HOME";
            // 
            // painel_principal_m
            // 
            this.painel_principal_m.Controls.Add(this.pictureBox1);
            this.painel_principal_m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_principal_m.Location = new System.Drawing.Point(246, 80);
            this.painel_principal_m.Name = "painel_principal_m";
            this.painel_principal_m.Size = new System.Drawing.Size(860, 501);
            this.painel_principal_m.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::projeto_integrado.Properties.Resources.imagem_2023_04_16_141523387;
            this.pictureBox1.Location = new System.Drawing.Point(265, 88);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gerenciamento_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 581);
            this.Controls.Add(this.painel_principal_m);
            this.Controls.Add(this.painel_titulo);
            this.Controls.Add(this.menu_lateral);
            this.Name = "gerenciamento_m";
            this.Text = "Form1";
            this.menu_lateral.ResumeLayout(false);
            this.painel_logo.ResumeLayout(false);
            this.painel_logo.PerformLayout();
            this.painel_titulo.ResumeLayout(false);
            this.painel_titulo.PerformLayout();
            this.painel_principal_m.ResumeLayout(false);
            this.painel_principal_m.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_lateral;
        private System.Windows.Forms.Button pagamento_m;
        private System.Windows.Forms.Button dependente_m;
        private System.Windows.Forms.Button principal_m;
        private System.Windows.Forms.Panel painel_logo;
        private System.Windows.Forms.Panel painel_titulo;
        private System.Windows.Forms.Label label_titulo_m;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painel_principal_m;
        private System.Windows.Forms.Button btn_fechar_forms_filho_m;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_minimizar_m;
        private System.Windows.Forms.Button btn_maximizar_m;
        private System.Windows.Forms.Button btn_fechar_m;
    }
}

