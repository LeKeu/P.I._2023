namespace projeto_integrado.Forms_p
{
    partial class Grupo_de_bens
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
            this.btn_deletar_grupo_de_bens_p = new System.Windows.Forms.Button();
            this.btn_editar_grupo_de_bens_p = new System.Windows.Forms.Button();
            this.btn_adicionar_grupo_de_bens_p = new System.Windows.Forms.Button();
            this.datagridview_grupo_de_bens_p = new System.Windows.Forms.DataGridView();
            this.btn_invisivel_patriGrBens_p = new System.Windows.Forms.Button();
            this.timer_patriGrpBens_p = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_grupo_de_bens_p)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deletar_grupo_de_bens_p
            // 
            this.btn_deletar_grupo_de_bens_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_deletar_grupo_de_bens_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_grupo_de_bens_p.Location = new System.Drawing.Point(714, 293);
            this.btn_deletar_grupo_de_bens_p.Name = "btn_deletar_grupo_de_bens_p";
            this.btn_deletar_grupo_de_bens_p.Size = new System.Drawing.Size(97, 42);
            this.btn_deletar_grupo_de_bens_p.TabIndex = 26;
            this.btn_deletar_grupo_de_bens_p.Text = "Deletar";
            this.btn_deletar_grupo_de_bens_p.UseVisualStyleBackColor = true;
            // 
            // btn_editar_grupo_de_bens_p
            // 
            this.btn_editar_grupo_de_bens_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editar_grupo_de_bens_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_grupo_de_bens_p.Location = new System.Drawing.Point(714, 217);
            this.btn_editar_grupo_de_bens_p.Name = "btn_editar_grupo_de_bens_p";
            this.btn_editar_grupo_de_bens_p.Size = new System.Drawing.Size(97, 42);
            this.btn_editar_grupo_de_bens_p.TabIndex = 25;
            this.btn_editar_grupo_de_bens_p.Text = "Editar";
            this.btn_editar_grupo_de_bens_p.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar_grupo_de_bens_p
            // 
            this.btn_adicionar_grupo_de_bens_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_adicionar_grupo_de_bens_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_grupo_de_bens_p.Location = new System.Drawing.Point(714, 143);
            this.btn_adicionar_grupo_de_bens_p.Name = "btn_adicionar_grupo_de_bens_p";
            this.btn_adicionar_grupo_de_bens_p.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_grupo_de_bens_p.TabIndex = 24;
            this.btn_adicionar_grupo_de_bens_p.Text = "Adicionar";
            this.btn_adicionar_grupo_de_bens_p.UseVisualStyleBackColor = true;
            this.btn_adicionar_grupo_de_bens_p.Click += new System.EventHandler(this.btn_adicionar_grupo_de_bens_p_Click);
            // 
            // datagridview_grupo_de_bens_p
            // 
            this.datagridview_grupo_de_bens_p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_grupo_de_bens_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_grupo_de_bens_p.Location = new System.Drawing.Point(46, 51);
            this.datagridview_grupo_de_bens_p.Name = "datagridview_grupo_de_bens_p";
            this.datagridview_grupo_de_bens_p.RowHeadersWidth = 51;
            this.datagridview_grupo_de_bens_p.RowTemplate.Height = 24;
            this.datagridview_grupo_de_bens_p.Size = new System.Drawing.Size(642, 369);
            this.datagridview_grupo_de_bens_p.TabIndex = 23;
            this.datagridview_grupo_de_bens_p.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_grupo_de_bens_p_CellDoubleClick);
            // 
            // btn_invisivel_patriGrBens_p
            // 
            this.btn_invisivel_patriGrBens_p.Location = new System.Drawing.Point(269, 435);
            this.btn_invisivel_patriGrBens_p.Name = "btn_invisivel_patriGrBens_p";
            this.btn_invisivel_patriGrBens_p.Size = new System.Drawing.Size(75, 23);
            this.btn_invisivel_patriGrBens_p.TabIndex = 27;
            this.btn_invisivel_patriGrBens_p.Text = "button1";
            this.btn_invisivel_patriGrBens_p.UseVisualStyleBackColor = true;
            this.btn_invisivel_patriGrBens_p.Click += new System.EventHandler(this.btn_invisivel_patriGrBens_p_Click);
            // 
            // timer_patriGrpBens_p
            // 
            this.timer_patriGrpBens_p.Interval = 5000;
            this.timer_patriGrpBens_p.Tick += new System.EventHandler(this.timer_patriGrpBens_p_Tick);
            // 
            // Grupo_de_bens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_invisivel_patriGrBens_p);
            this.Controls.Add(this.btn_deletar_grupo_de_bens_p);
            this.Controls.Add(this.btn_editar_grupo_de_bens_p);
            this.Controls.Add(this.btn_adicionar_grupo_de_bens_p);
            this.Controls.Add(this.datagridview_grupo_de_bens_p);
            this.Name = "Grupo_de_bens";
            this.Text = "Grupo_de_bens";
            this.Load += new System.EventHandler(this.Grupo_de_bens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_grupo_de_bens_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deletar_grupo_de_bens_p;
        private System.Windows.Forms.Button btn_editar_grupo_de_bens_p;
        private System.Windows.Forms.Button btn_adicionar_grupo_de_bens_p;
        private System.Windows.Forms.DataGridView datagridview_grupo_de_bens_p;
        private System.Windows.Forms.Button btn_invisivel_patriGrBens_p;
        private System.Windows.Forms.Timer timer_patriGrpBens_p;
    }
}