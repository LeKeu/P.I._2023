namespace projeto_integrado
{
    partial class gerenciamento_p
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
            this.painel_principal_p = new System.Windows.Forms.Panel();
            this.painel_titulo_p = new System.Windows.Forms.Panel();
            this.btn_minimizar_p = new System.Windows.Forms.Button();
            this.btn_maximizar_p = new System.Windows.Forms.Button();
            this.btn_fechar_p = new System.Windows.Forms.Button();
            this.label_titulo_p = new System.Windows.Forms.Label();
            this.painel_menu_lateral_p = new System.Windows.Forms.Panel();
            this.painel_logo_p = new System.Windows.Forms.Panel();
            this.lbl_projeto_integrado_p = new System.Windows.Forms.Label();
            this.btn_fechar_forms_filho_p = new System.Windows.Forms.Button();
            this.btn_grupo_de_bens_p = new System.Windows.Forms.Button();
            this.btn_setor_p = new System.Windows.Forms.Button();
            this.btn_fornecedor_p = new System.Windows.Forms.Button();
            this.btn_fabricantes_p = new System.Windows.Forms.Button();
            this.btn_produto_p = new System.Windows.Forms.Button();
            this.btn_principal_p = new System.Windows.Forms.Button();
            this.panel_gerenciarpatrimonio_p = new System.Windows.Forms.Panel();
            this.btn_gerenciarpatrimonio_p = new System.Windows.Forms.Button();
            this.label_gerenciarpatrimonio_p = new System.Windows.Forms.Label();
            this.pictureBox_gerenciarpatrimonio_p = new System.Windows.Forms.PictureBox();
            this.painel_gerenciarmembros_p = new System.Windows.Forms.Panel();
            this.btn_gerenciarmembros_p = new System.Windows.Forms.Button();
            this.label_titulo_gerenciarmembros_p = new System.Windows.Forms.Label();
            this.pictureBox_gerenciarmembros_p = new System.Windows.Forms.PictureBox();
            this.painel_principal_p.SuspendLayout();
            this.painel_titulo_p.SuspendLayout();
            this.painel_menu_lateral_p.SuspendLayout();
            this.painel_logo_p.SuspendLayout();
            this.panel_gerenciarpatrimonio_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gerenciarpatrimonio_p)).BeginInit();
            this.painel_gerenciarmembros_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gerenciarmembros_p)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_principal_p
            // 
            this.painel_principal_p.Controls.Add(this.panel_gerenciarpatrimonio_p);
            this.painel_principal_p.Controls.Add(this.painel_gerenciarmembros_p);
            this.painel_principal_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_principal_p.Location = new System.Drawing.Point(246, 80);
            this.painel_principal_p.Name = "painel_principal_p";
            this.painel_principal_p.Size = new System.Drawing.Size(860, 501);
            this.painel_principal_p.TabIndex = 5;
            // 
            // painel_titulo_p
            // 
            this.painel_titulo_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.painel_titulo_p.Controls.Add(this.btn_minimizar_p);
            this.painel_titulo_p.Controls.Add(this.btn_maximizar_p);
            this.painel_titulo_p.Controls.Add(this.btn_fechar_p);
            this.painel_titulo_p.Controls.Add(this.btn_fechar_forms_filho_p);
            this.painel_titulo_p.Controls.Add(this.label_titulo_p);
            this.painel_titulo_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_titulo_p.Location = new System.Drawing.Point(246, 0);
            this.painel_titulo_p.Name = "painel_titulo_p";
            this.painel_titulo_p.Size = new System.Drawing.Size(860, 80);
            this.painel_titulo_p.TabIndex = 4;
            this.painel_titulo_p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painel_titulo_p_MouseDown);
            // 
            // btn_minimizar_p
            // 
            this.btn_minimizar_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar_p.FlatAppearance.BorderSize = 0;
            this.btn_minimizar_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar_p.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar_p.Location = new System.Drawing.Point(766, 0);
            this.btn_minimizar_p.Name = "btn_minimizar_p";
            this.btn_minimizar_p.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar_p.TabIndex = 4;
            this.btn_minimizar_p.Text = "-";
            this.btn_minimizar_p.UseVisualStyleBackColor = true;
            this.btn_minimizar_p.Click += new System.EventHandler(this.btn_minimizar_p_Click);
            // 
            // btn_maximizar_p
            // 
            this.btn_maximizar_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar_p.FlatAppearance.BorderSize = 0;
            this.btn_maximizar_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximizar_p.ForeColor = System.Drawing.Color.White;
            this.btn_maximizar_p.Location = new System.Drawing.Point(797, 0);
            this.btn_maximizar_p.Name = "btn_maximizar_p";
            this.btn_maximizar_p.Size = new System.Drawing.Size(30, 30);
            this.btn_maximizar_p.TabIndex = 3;
            this.btn_maximizar_p.Text = "O";
            this.btn_maximizar_p.UseVisualStyleBackColor = true;
            this.btn_maximizar_p.Click += new System.EventHandler(this.btn_maximizar_p_Click);
            // 
            // btn_fechar_p
            // 
            this.btn_fechar_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar_p.FlatAppearance.BorderSize = 0;
            this.btn_fechar_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar_p.ForeColor = System.Drawing.Color.White;
            this.btn_fechar_p.Location = new System.Drawing.Point(827, 0);
            this.btn_fechar_p.Name = "btn_fechar_p";
            this.btn_fechar_p.Size = new System.Drawing.Size(30, 30);
            this.btn_fechar_p.TabIndex = 2;
            this.btn_fechar_p.Text = "X";
            this.btn_fechar_p.UseVisualStyleBackColor = true;
            this.btn_fechar_p.Click += new System.EventHandler(this.btn_fechar_p_Click);
            // 
            // label_titulo_p
            // 
            this.label_titulo_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_titulo_p.AutoSize = true;
            this.label_titulo_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_p.ForeColor = System.Drawing.Color.White;
            this.label_titulo_p.Location = new System.Drawing.Point(396, 25);
            this.label_titulo_p.Name = "label_titulo_p";
            this.label_titulo_p.Size = new System.Drawing.Size(95, 31);
            this.label_titulo_p.TabIndex = 0;
            this.label_titulo_p.Text = "HOME";
            // 
            // painel_menu_lateral_p
            // 
            this.painel_menu_lateral_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.painel_menu_lateral_p.Controls.Add(this.btn_grupo_de_bens_p);
            this.painel_menu_lateral_p.Controls.Add(this.btn_setor_p);
            this.painel_menu_lateral_p.Controls.Add(this.btn_fornecedor_p);
            this.painel_menu_lateral_p.Controls.Add(this.btn_fabricantes_p);
            this.painel_menu_lateral_p.Controls.Add(this.btn_produto_p);
            this.painel_menu_lateral_p.Controls.Add(this.btn_principal_p);
            this.painel_menu_lateral_p.Controls.Add(this.painel_logo_p);
            this.painel_menu_lateral_p.Dock = System.Windows.Forms.DockStyle.Left;
            this.painel_menu_lateral_p.Location = new System.Drawing.Point(0, 0);
            this.painel_menu_lateral_p.Name = "painel_menu_lateral_p";
            this.painel_menu_lateral_p.Size = new System.Drawing.Size(246, 581);
            this.painel_menu_lateral_p.TabIndex = 3;
            // 
            // painel_logo_p
            // 
            this.painel_logo_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.painel_logo_p.Controls.Add(this.lbl_projeto_integrado_p);
            this.painel_logo_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_logo_p.Location = new System.Drawing.Point(0, 0);
            this.painel_logo_p.Name = "painel_logo_p";
            this.painel_logo_p.Size = new System.Drawing.Size(246, 80);
            this.painel_logo_p.TabIndex = 0;
            // 
            // lbl_projeto_integrado_p
            // 
            this.lbl_projeto_integrado_p.AutoSize = true;
            this.lbl_projeto_integrado_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_projeto_integrado_p.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_projeto_integrado_p.Location = new System.Drawing.Point(43, 31);
            this.lbl_projeto_integrado_p.Name = "lbl_projeto_integrado_p";
            this.lbl_projeto_integrado_p.Size = new System.Drawing.Size(160, 25);
            this.lbl_projeto_integrado_p.TabIndex = 0;
            this.lbl_projeto_integrado_p.Text = "Projeto Integrado";
            // 
            // btn_fechar_forms_filho_p
            // 
            this.btn_fechar_forms_filho_p.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_fechar_forms_filho_p.FlatAppearance.BorderSize = 0;
            this.btn_fechar_forms_filho_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_forms_filho_p.Image = global::projeto_integrado.Properties.Resources.close__1_;
            this.btn_fechar_forms_filho_p.Location = new System.Drawing.Point(0, 0);
            this.btn_fechar_forms_filho_p.Name = "btn_fechar_forms_filho_p";
            this.btn_fechar_forms_filho_p.Size = new System.Drawing.Size(75, 80);
            this.btn_fechar_forms_filho_p.TabIndex = 1;
            this.btn_fechar_forms_filho_p.UseVisualStyleBackColor = true;
            this.btn_fechar_forms_filho_p.Click += new System.EventHandler(this.btn_fechar_forms_filho_p_Click);
            // 
            // btn_grupo_de_bens_p
            // 
            this.btn_grupo_de_bens_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_grupo_de_bens_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_grupo_de_bens_p.FlatAppearance.BorderSize = 0;
            this.btn_grupo_de_bens_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grupo_de_bens_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grupo_de_bens_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_grupo_de_bens_p.Image = global::projeto_integrado.Properties.Resources.bens;
            this.btn_grupo_de_bens_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grupo_de_bens_p.Location = new System.Drawing.Point(0, 380);
            this.btn_grupo_de_bens_p.Name = "btn_grupo_de_bens_p";
            this.btn_grupo_de_bens_p.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_grupo_de_bens_p.Size = new System.Drawing.Size(246, 60);
            this.btn_grupo_de_bens_p.TabIndex = 6;
            this.btn_grupo_de_bens_p.Text = "    Grupo de bens";
            this.btn_grupo_de_bens_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grupo_de_bens_p.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_grupo_de_bens_p.UseVisualStyleBackColor = false;
            this.btn_grupo_de_bens_p.Click += new System.EventHandler(this.btn_grupo_de_bens_p_Click);
            // 
            // btn_setor_p
            // 
            this.btn_setor_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_setor_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_setor_p.FlatAppearance.BorderSize = 0;
            this.btn_setor_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setor_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setor_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_setor_p.Image = global::projeto_integrado.Properties.Resources.grafico_de_setores;
            this.btn_setor_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setor_p.Location = new System.Drawing.Point(0, 320);
            this.btn_setor_p.Name = "btn_setor_p";
            this.btn_setor_p.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_setor_p.Size = new System.Drawing.Size(246, 60);
            this.btn_setor_p.TabIndex = 5;
            this.btn_setor_p.Text = "    Setor";
            this.btn_setor_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setor_p.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setor_p.UseVisualStyleBackColor = false;
            this.btn_setor_p.Click += new System.EventHandler(this.btn_setor_p_Click);
            // 
            // btn_fornecedor_p
            // 
            this.btn_fornecedor_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_fornecedor_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fornecedor_p.FlatAppearance.BorderSize = 0;
            this.btn_fornecedor_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fornecedor_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fornecedor_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_fornecedor_p.Image = global::projeto_integrado.Properties.Resources.entregador;
            this.btn_fornecedor_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fornecedor_p.Location = new System.Drawing.Point(0, 260);
            this.btn_fornecedor_p.Name = "btn_fornecedor_p";
            this.btn_fornecedor_p.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_fornecedor_p.Size = new System.Drawing.Size(246, 60);
            this.btn_fornecedor_p.TabIndex = 4;
            this.btn_fornecedor_p.Text = "    Fornecedor";
            this.btn_fornecedor_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fornecedor_p.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fornecedor_p.UseVisualStyleBackColor = false;
            this.btn_fornecedor_p.Click += new System.EventHandler(this.btn_fornecedor_p_Click);
            // 
            // btn_fabricantes_p
            // 
            this.btn_fabricantes_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_fabricantes_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fabricantes_p.FlatAppearance.BorderSize = 0;
            this.btn_fabricantes_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fabricantes_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fabricantes_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_fabricantes_p.Image = global::projeto_integrado.Properties.Resources.fabricar;
            this.btn_fabricantes_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fabricantes_p.Location = new System.Drawing.Point(0, 200);
            this.btn_fabricantes_p.Name = "btn_fabricantes_p";
            this.btn_fabricantes_p.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_fabricantes_p.Size = new System.Drawing.Size(246, 60);
            this.btn_fabricantes_p.TabIndex = 3;
            this.btn_fabricantes_p.Text = "    Fabricantes";
            this.btn_fabricantes_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fabricantes_p.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fabricantes_p.UseVisualStyleBackColor = false;
            this.btn_fabricantes_p.Click += new System.EventHandler(this.btn_fabricantes_p_Click);
            // 
            // btn_produto_p
            // 
            this.btn_produto_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_produto_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_produto_p.FlatAppearance.BorderSize = 0;
            this.btn_produto_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produto_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_produto_p.Image = global::projeto_integrado.Properties.Resources.caracteristicas;
            this.btn_produto_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produto_p.Location = new System.Drawing.Point(0, 140);
            this.btn_produto_p.Name = "btn_produto_p";
            this.btn_produto_p.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_produto_p.Size = new System.Drawing.Size(246, 60);
            this.btn_produto_p.TabIndex = 2;
            this.btn_produto_p.Text = "    Produto";
            this.btn_produto_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produto_p.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_produto_p.UseVisualStyleBackColor = false;
            this.btn_produto_p.Click += new System.EventHandler(this.btn_produto_p_Click);
            // 
            // btn_principal_p
            // 
            this.btn_principal_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_principal_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_principal_p.FlatAppearance.BorderSize = 0;
            this.btn_principal_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_principal_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_principal_p.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_principal_p.Image = global::projeto_integrado.Properties.Resources.seguro;
            this.btn_principal_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_principal_p.Location = new System.Drawing.Point(0, 80);
            this.btn_principal_p.Name = "btn_principal_p";
            this.btn_principal_p.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_principal_p.Size = new System.Drawing.Size(246, 60);
            this.btn_principal_p.TabIndex = 1;
            this.btn_principal_p.Text = "    Patrimônio";
            this.btn_principal_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_principal_p.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_principal_p.UseVisualStyleBackColor = false;
            this.btn_principal_p.Click += new System.EventHandler(this.btn_principal_p_Click);
            // 
            // panel_gerenciarpatrimonio_p
            // 
            this.panel_gerenciarpatrimonio_p.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_gerenciarpatrimonio_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_gerenciarpatrimonio_p.Controls.Add(this.btn_gerenciarpatrimonio_p);
            this.panel_gerenciarpatrimonio_p.Controls.Add(this.label_gerenciarpatrimonio_p);
            this.panel_gerenciarpatrimonio_p.Controls.Add(this.pictureBox_gerenciarpatrimonio_p);
            this.panel_gerenciarpatrimonio_p.Location = new System.Drawing.Point(463, 99);
            this.panel_gerenciarpatrimonio_p.Name = "panel_gerenciarpatrimonio_p";
            this.panel_gerenciarpatrimonio_p.Size = new System.Drawing.Size(258, 302);
            this.panel_gerenciarpatrimonio_p.TabIndex = 9;
            // 
            // btn_gerenciarpatrimonio_p
            // 
            this.btn_gerenciarpatrimonio_p.BackColor = System.Drawing.Color.White;
            this.btn_gerenciarpatrimonio_p.Enabled = false;
            this.btn_gerenciarpatrimonio_p.FlatAppearance.BorderSize = 0;
            this.btn_gerenciarpatrimonio_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciarpatrimonio_p.Location = new System.Drawing.Point(81, 197);
            this.btn_gerenciarpatrimonio_p.Name = "btn_gerenciarpatrimonio_p";
            this.btn_gerenciarpatrimonio_p.Size = new System.Drawing.Size(101, 32);
            this.btn_gerenciarpatrimonio_p.TabIndex = 6;
            this.btn_gerenciarpatrimonio_p.Text = "Gerenciar";
            this.btn_gerenciarpatrimonio_p.UseVisualStyleBackColor = false;
            // 
            // label_gerenciarpatrimonio_p
            // 
            this.label_gerenciarpatrimonio_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_gerenciarpatrimonio_p.AutoSize = true;
            this.label_gerenciarpatrimonio_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_gerenciarpatrimonio_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gerenciarpatrimonio_p.ForeColor = System.Drawing.Color.White;
            this.label_gerenciarpatrimonio_p.Location = new System.Drawing.Point(58, 128);
            this.label_gerenciarpatrimonio_p.Name = "label_gerenciarpatrimonio_p";
            this.label_gerenciarpatrimonio_p.Size = new System.Drawing.Size(143, 31);
            this.label_gerenciarpatrimonio_p.TabIndex = 5;
            this.label_gerenciarpatrimonio_p.Text = "Patrimônio";
            // 
            // pictureBox_gerenciarpatrimonio_p
            // 
            this.pictureBox_gerenciarpatrimonio_p.Image = global::projeto_integrado.Properties.Resources.monumento;
            this.pictureBox_gerenciarpatrimonio_p.Location = new System.Drawing.Point(92, 32);
            this.pictureBox_gerenciarpatrimonio_p.Name = "pictureBox_gerenciarpatrimonio_p";
            this.pictureBox_gerenciarpatrimonio_p.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_gerenciarpatrimonio_p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_gerenciarpatrimonio_p.TabIndex = 0;
            this.pictureBox_gerenciarpatrimonio_p.TabStop = false;
            // 
            // painel_gerenciarmembros_p
            // 
            this.painel_gerenciarmembros_p.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.painel_gerenciarmembros_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.painel_gerenciarmembros_p.Controls.Add(this.btn_gerenciarmembros_p);
            this.painel_gerenciarmembros_p.Controls.Add(this.label_titulo_gerenciarmembros_p);
            this.painel_gerenciarmembros_p.Controls.Add(this.pictureBox_gerenciarmembros_p);
            this.painel_gerenciarmembros_p.Location = new System.Drawing.Point(139, 99);
            this.painel_gerenciarmembros_p.Name = "painel_gerenciarmembros_p";
            this.painel_gerenciarmembros_p.Size = new System.Drawing.Size(258, 302);
            this.painel_gerenciarmembros_p.TabIndex = 8;
            // 
            // btn_gerenciarmembros_p
            // 
            this.btn_gerenciarmembros_p.BackColor = System.Drawing.Color.White;
            this.btn_gerenciarmembros_p.FlatAppearance.BorderSize = 0;
            this.btn_gerenciarmembros_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciarmembros_p.Location = new System.Drawing.Point(81, 197);
            this.btn_gerenciarmembros_p.Name = "btn_gerenciarmembros_p";
            this.btn_gerenciarmembros_p.Size = new System.Drawing.Size(101, 32);
            this.btn_gerenciarmembros_p.TabIndex = 6;
            this.btn_gerenciarmembros_p.Text = "Gerenciar";
            this.btn_gerenciarmembros_p.UseVisualStyleBackColor = false;
            this.btn_gerenciarmembros_p.Click += new System.EventHandler(this.btn_gerenciarmembros_p_Click);
            // 
            // label_titulo_gerenciarmembros_p
            // 
            this.label_titulo_gerenciarmembros_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_titulo_gerenciarmembros_p.AutoSize = true;
            this.label_titulo_gerenciarmembros_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_titulo_gerenciarmembros_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_gerenciarmembros_p.ForeColor = System.Drawing.Color.White;
            this.label_titulo_gerenciarmembros_p.Location = new System.Drawing.Point(66, 128);
            this.label_titulo_gerenciarmembros_p.Name = "label_titulo_gerenciarmembros_p";
            this.label_titulo_gerenciarmembros_p.Size = new System.Drawing.Size(126, 31);
            this.label_titulo_gerenciarmembros_p.TabIndex = 5;
            this.label_titulo_gerenciarmembros_p.Text = "Membros";
            // 
            // pictureBox_gerenciarmembros_p
            // 
            this.pictureBox_gerenciarmembros_p.Image = global::projeto_integrado.Properties.Resources.trabalho_em_equipe;
            this.pictureBox_gerenciarmembros_p.Location = new System.Drawing.Point(92, 32);
            this.pictureBox_gerenciarmembros_p.Name = "pictureBox_gerenciarmembros_p";
            this.pictureBox_gerenciarmembros_p.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_gerenciarmembros_p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_gerenciarmembros_p.TabIndex = 0;
            this.pictureBox_gerenciarmembros_p.TabStop = false;
            // 
            // gerenciamento_p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 581);
            this.Controls.Add(this.painel_principal_p);
            this.Controls.Add(this.painel_titulo_p);
            this.Controls.Add(this.painel_menu_lateral_p);
            this.Name = "gerenciamento_p";
            this.Text = "gerenciamento_p";
            this.painel_principal_p.ResumeLayout(false);
            this.painel_titulo_p.ResumeLayout(false);
            this.painel_titulo_p.PerformLayout();
            this.painel_menu_lateral_p.ResumeLayout(false);
            this.painel_logo_p.ResumeLayout(false);
            this.painel_logo_p.PerformLayout();
            this.panel_gerenciarpatrimonio_p.ResumeLayout(false);
            this.panel_gerenciarpatrimonio_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gerenciarpatrimonio_p)).EndInit();
            this.painel_gerenciarmembros_p.ResumeLayout(false);
            this.painel_gerenciarmembros_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gerenciarmembros_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_principal_p;
        private System.Windows.Forms.Panel painel_titulo_p;
        private System.Windows.Forms.Button btn_minimizar_p;
        private System.Windows.Forms.Button btn_maximizar_p;
        private System.Windows.Forms.Button btn_fechar_p;
        private System.Windows.Forms.Button btn_fechar_forms_filho_p;
        private System.Windows.Forms.Label label_titulo_p;
        private System.Windows.Forms.Panel painel_menu_lateral_p;
        private System.Windows.Forms.Button btn_fabricantes_p;
        private System.Windows.Forms.Button btn_produto_p;
        private System.Windows.Forms.Button btn_principal_p;
        private System.Windows.Forms.Panel painel_logo_p;
        private System.Windows.Forms.Label lbl_projeto_integrado_p;
        private System.Windows.Forms.Button btn_grupo_de_bens_p;
        private System.Windows.Forms.Button btn_setor_p;
        private System.Windows.Forms.Button btn_fornecedor_p;
        private System.Windows.Forms.Panel panel_gerenciarpatrimonio_p;
        private System.Windows.Forms.Button btn_gerenciarpatrimonio_p;
        private System.Windows.Forms.Label label_gerenciarpatrimonio_p;
        private System.Windows.Forms.PictureBox pictureBox_gerenciarpatrimonio_p;
        private System.Windows.Forms.Panel painel_gerenciarmembros_p;
        private System.Windows.Forms.Button btn_gerenciarmembros_p;
        private System.Windows.Forms.Label label_titulo_gerenciarmembros_p;
        private System.Windows.Forms.PictureBox pictureBox_gerenciarmembros_p;
    }
}