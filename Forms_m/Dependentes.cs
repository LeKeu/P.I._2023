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
    public partial class Dependentes : Form
    {
        public Dependentes()
        {
            InitializeComponent();
            datagridview_dependentes_m.DataSource = json_funcs.Read_from_json();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_dependentes_m.PerformClick();
        }

        private void Dependentes_Load(object sender, EventArgs e)
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

        private void btn_adicionar_dependentes_m_Click(object sender, EventArgs e)
        {
            var forminputdependentes = new dependentes_inputs();
            forminputdependentes.Show();
        }

        private void datagridview_dependentes_m_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_invisivel_dependentes_m_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datagridview_dependentes_m.Rows.Count - 1; i++)
            {

                var row = datagridview_dependentes_m.Rows[i];

                if (row.Cells[0].Value.ToString() != "Dependente")
                {
                    //MessageBox.Show(row.Cells[0].Value.ToString());
                    datagridview_dependentes_m.CurrentCell = null;
                    row.Visible = false;
                    row.Selected = false;
                    
                }
            }
        }
    }
}
