namespace projeto_integrado.Forms_p
{
    partial class Fabricantes
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
            this.btn_deletar_fabricantes_p = new System.Windows.Forms.Button();
            this.btn_editar_fabricantes_p = new System.Windows.Forms.Button();
            this.btn_adicionar_fabricantes_p = new System.Windows.Forms.Button();
            this.datagridview_fabricantes_p = new System.Windows.Forms.DataGridView();
            this.btn_invisivel_patrFabr_p = new System.Windows.Forms.Button();
            this.timer_patrFabr_p = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_fabricantes_p)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deletar_fabricantes_p
            // 
            this.btn_deletar_fabricantes_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_deletar_fabricantes_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_fabricantes_p.Location = new System.Drawing.Point(721, 295);
            this.btn_deletar_fabricantes_p.Name = "btn_deletar_fabricantes_p";
            this.btn_deletar_fabricantes_p.Size = new System.Drawing.Size(97, 42);
            this.btn_deletar_fabricantes_p.TabIndex = 22;
            this.btn_deletar_fabricantes_p.Text = "Deletar";
            this.btn_deletar_fabricantes_p.UseVisualStyleBackColor = true;
            // 
            // btn_editar_fabricantes_p
            // 
            this.btn_editar_fabricantes_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editar_fabricantes_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_fabricantes_p.Location = new System.Drawing.Point(721, 219);
            this.btn_editar_fabricantes_p.Name = "btn_editar_fabricantes_p";
            this.btn_editar_fabricantes_p.Size = new System.Drawing.Size(97, 42);
            this.btn_editar_fabricantes_p.TabIndex = 21;
            this.btn_editar_fabricantes_p.Text = "Editar";
            this.btn_editar_fabricantes_p.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar_fabricantes_p
            // 
            this.btn_adicionar_fabricantes_p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_adicionar_fabricantes_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_fabricantes_p.Location = new System.Drawing.Point(721, 145);
            this.btn_adicionar_fabricantes_p.Name = "btn_adicionar_fabricantes_p";
            this.btn_adicionar_fabricantes_p.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_fabricantes_p.TabIndex = 20;
            this.btn_adicionar_fabricantes_p.Text = "Adicionar";
            this.btn_adicionar_fabricantes_p.UseVisualStyleBackColor = true;
            this.btn_adicionar_fabricantes_p.Click += new System.EventHandler(this.btn_adicionar_fabricantes_p_Click);
            // 
            // datagridview_fabricantes_p
            // 
            this.datagridview_fabricantes_p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_fabricantes_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_fabricantes_p.Location = new System.Drawing.Point(53, 53);
            this.datagridview_fabricantes_p.Name = "datagridview_fabricantes_p";
            this.datagridview_fabricantes_p.RowHeadersWidth = 51;
            this.datagridview_fabricantes_p.RowTemplate.Height = 24;
            this.datagridview_fabricantes_p.Size = new System.Drawing.Size(642, 369);
            this.datagridview_fabricantes_p.TabIndex = 19;
            this.datagridview_fabricantes_p.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_fabricantes_p_CellDoubleClick);
            // 
            // btn_invisivel_patrFabr_p
            // 
            this.btn_invisivel_patrFabr_p.Location = new System.Drawing.Point(169, 429);
            this.btn_invisivel_patrFabr_p.Name = "btn_invisivel_patrFabr_p";
            this.btn_invisivel_patrFabr_p.Size = new System.Drawing.Size(75, 23);
            this.btn_invisivel_patrFabr_p.TabIndex = 23;
            this.btn_invisivel_patrFabr_p.Text = "button1";
            this.btn_invisivel_patrFabr_p.UseVisualStyleBackColor = true;
            this.btn_invisivel_patrFabr_p.Click += new System.EventHandler(this.btn_invisivel_patrFabr_p_Click);
            // 
            // timer_patrFabr_p
            // 
            this.timer_patrFabr_p.Interval = 5000;
            this.timer_patrFabr_p.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Fabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_invisivel_patrFabr_p);
            this.Controls.Add(this.btn_deletar_fabricantes_p);
            this.Controls.Add(this.btn_editar_fabricantes_p);
            this.Controls.Add(this.btn_adicionar_fabricantes_p);
            this.Controls.Add(this.datagridview_fabricantes_p);
            this.Name = "Fabricantes";
            this.Text = "Fabricantes";
            this.Load += new System.EventHandler(this.Fabricantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_fabricantes_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deletar_fabricantes_p;
        private System.Windows.Forms.Button btn_editar_fabricantes_p;
        private System.Windows.Forms.Button btn_adicionar_fabricantes_p;
        private System.Windows.Forms.DataGridView datagridview_fabricantes_p;
        private System.Windows.Forms.Button btn_invisivel_patrFabr_p;
        private System.Windows.Forms.Timer timer_patrFabr_p;
    }
}