using projeto_integrado.Classes;
using projeto_integrado.Forms_m_inputs;
using projeto_integrado.Forms_m_inputs_editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Forms
{
    public partial class Dependentes : Form
    {
        public static string id_dep;
        public Dependentes()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_dependentes_m.PerformClick();
        }

        private void Dependentes_Load(object sender, EventArgs e)
        {
            timer_dependente_m.Start();
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
            /*
         Parte que tira as colunas de outras tables
         */
            datagridview_dependentes_m.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_dependentes_m, "Dependente", "H");

        }

        private void datagridview_dependentes_m_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_dependentes_m.Rows[indexRow];

            for (int i = 0; i < row.Cells.Count; i++)
            {
                //Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }
            id_dep = row.Cells[3].Value.ToString();

            var forminputeditardependentes = new dependentes_inputs_editar();
            forminputeditardependentes.input_editar_dependente_nome_m.Text = row.Cells[3].Value.ToString();
            forminputeditardependentes.input_editar_dependente_sexo_m.Text = row.Cells[17].Value.ToString();
            forminputeditardependentes.dateTimePicker_editar_dependente_datanasc_m.Text = row.Cells[4].Value.ToString();
            forminputeditardependentes.input_editar_dependente_parentesco_m.Text = row.Cells[29].Value.ToString();
            forminputeditardependentes.input_editar_dependente_nomemembrovinculado_m.Text = row.Cells[26].Value.ToString();
            forminputeditardependentes.img_editar_dependente.Image = System.Drawing.Image.FromStream(new MemoryStream(Convert.FromBase64String(row.Cells[28].Value.ToString())));
            forminputeditardependentes.Show();
        }

        private void timer_dependente_m_Tick(object sender, EventArgs e)
        {
            datagridview_dependentes_m.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_dependentes_m, "Dependente", "H");
            timer_dependente_m.Start();
        }
    }
}
