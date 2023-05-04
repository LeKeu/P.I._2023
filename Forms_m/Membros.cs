using projeto_integrado.Classes;
using projeto_integrado.Forms_m_inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Forms
{
    public partial class Membros : Form
    {
        public Membros()
        {
            InitializeComponent();
            datagridview_membros_m.DataSource = json_funcs.Read_from_json_datagridview();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_membros_m.PerformClick();
        }

        private void Membros_Load_1(object sender, EventArgs e)
        {
            CarregarTema();
        }

        private void CarregarTema()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = CorTema.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = CorTema.SecondaryColor;
                }
            }
        }

        private void btn_adicionar_membros_m_Click(object sender, EventArgs e)
        {
            var forminputmembros = new membros_inputs();
            forminputmembros.Show();
        }

        private void datagridview_membros_m_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_invisivel_membros_m_Click(object sender, EventArgs e)
        {
            /*
             Parte que tira as colunas de outras tables
             */
            datagridview_membros_m.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            datagridview_membros_m.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var values_colunas = conexao_api.ReadTableColumnName("Membro", "Y");

            for (int i = 0; i < datagridview_membros_m.Rows.Count - 1; i++)
            {

                var row = datagridview_membros_m.Rows[i];

                if (row.Cells[0].Value.ToString() != "Membro")
                {
                    datagridview_membros_m.CurrentCell = null;
                    row.Visible = false;
                    row.Selected = false;
                }
            }

            for (int i = 0; i < datagridview_membros_m.Columns.Count; i++)
            {
                datagridview_membros_m.Columns[i].Visible = false;
            }

            foreach (var coluna in values_colunas)
            {
                for (int i = 0; i < coluna.Count; i++)
                {
                    datagridview_membros_m.Columns[(string)coluna[i]].Visible = true;
                    
                }
            }
        }

        public void refreshtable()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
