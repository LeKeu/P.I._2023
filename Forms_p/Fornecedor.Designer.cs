namespace projeto_integrado.Forms_p
{
    partial class Fornecedor
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
            this.btn_adicionar_fornecedor_p = new System.Windows.Forms.Button();
            this.datagridview_fornecedor_p = new System.Windows.Forms.DataGridView();
            this.btn_invisivel_patriForn_p = new System.Windows.Forms.Button();
            this.timer_patriForn_p = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_fornecedor_p)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adicionar_fornecedor_p
            // 
            this.btn_adicionar_fornecedor_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionar_fornecedor_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_fornecedor_p.Location = new System.Drawing.Point(709, 378);
            this.btn_adicionar_fornecedor_p.Name = "btn_adicionar_fornecedor_p";
            this.btn_adicionar_fornecedor_p.Size = new System.Drawing.Size(97, 42);
            this.btn_adicionar_fornecedor_p.TabIndex = 20;
            this.btn_adicionar_fornecedor_p.Text = "Adicionar";
            this.btn_adicionar_fornecedor_p.UseVisualStyleBackColor = true;
            this.btn_adicionar_fornecedor_p.Click += new System.EventHandler(this.btn_adicionar_fornecedor_p_Click);
            // 
            // datagridview_fornecedor_p
            // 
            this.datagridview_fornecedor_p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_fornecedor_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_fornecedor_p.Location = new System.Drawing.Point(57, 51);
            this.datagridview_fornecedor_p.Name = "datagridview_fornecedor_p";
            this.datagridview_fornecedor_p.RowHeadersWidth = 51;
            this.datagridview_fornecedor_p.RowTemplate.Height = 24;
            this.datagridview_fornecedor_p.Size = new System.Drawing.Size(642, 369);
            this.datagridview_fornecedor_p.TabIndex = 19;
            this.datagridview_fornecedor_p.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_fornecedor_p_CellDoubleClick);
            // 
            // btn_invisivel_patriForn_p
            // 
            this.btn_invisivel_patriForn_p.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_invisivel_patriForn_p.Location = new System.Drawing.Point(261, 440);
            this.btn_invisivel_patriForn_p.Name = "btn_invisivel_patriForn_p";
            this.btn_invisivel_patriForn_p.Size = new System.Drawing.Size(75, 23);
            this.btn_invisivel_patriForn_p.TabIndex = 23;
            this.btn_invisivel_patriForn_p.Text = "button1";
            this.btn_invisivel_patriForn_p.UseVisualStyleBackColor = true;
            this.btn_invisivel_patriForn_p.Visible = false;
            this.btn_invisivel_patriForn_p.Click += new System.EventHandler(this.btn_invisivel_patriForn_p_Click);
            // 
            // timer_patriForn_p
            // 
            this.timer_patriForn_p.Tick += new System.EventHandler(this.timer_patriForn_p_Tick);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.btn_invisivel_patriForn_p);
            this.Controls.Add(this.btn_adicionar_fornecedor_p);
            this.Controls.Add(this.datagridview_fornecedor_p);
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_fornecedor_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_adicionar_fornecedor_p;
        private System.Windows.Forms.DataGridView datagridview_fornecedor_p;
        private System.Windows.Forms.Button btn_invisivel_patriForn_p;
        private System.Windows.Forms.Timer timer_patriForn_p;
    }
}