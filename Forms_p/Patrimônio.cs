using projeto_integrado.Classes;
using projeto_integrado.Forms_m_inputs;
using projeto_integrado.Forms_m_inputs_editar;
using projeto_integrado.Forms_p_inputs;
using projeto_integrado.Forms_p_inputs_editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Forms_p
{
    public partial class Patrimônio : Form
    {
        public Patrimônio()
        {
            InitializeComponent();
            datagridview_patrimonio_p.DataSource = json_funcs.Read_from_json_datagridview();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_patrimonio_m.PerformClick();
        }

        private void Patrimônio_Load(object sender, EventArgs e)
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

        private void btn_adicionar_patrimonio_p_Click(object sender, EventArgs e)
        {
            var forminputpatrimonio = new patrimonio_inputs();
            forminputpatrimonio.Show();
        }

        private void btn_invisivel_patrimonio_m_Click(object sender, EventArgs e)
        {
            datagridview_patrimonio_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_patrimonio_p, "Patrimonio", "P");
        }

        private void datagridview_patrimonio_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_patrimonio_p.Rows[indexRow];

            var forminputeditarpatrimonio = new Patrimonio_inputs_editar();
            forminputeditarpatrimonio.input_editar_patrimonio_numpat_p.Text = row.Cells[1].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_numserie_p.Text = row.Cells[2].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_notafiscal_p.Text = row.Cells[3].Value.ToString();
            forminputeditarpatrimonio.dateTimePicker_editar_patrimonio_datacompra_p.Text = row.Cells[4].Value.ToString();
            forminputeditarpatrimonio.dateTimePicker_editar_patrimonio_fimgarantia_p.Text = row.Cells[5].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_valorbem_p.Text = row.Cells[6].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_estadoconservacao_p.Text = row.Cells[7].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_valoratual_p.Text = row.Cells[8].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_status_p.Text = row.Cells[14].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_ordemcompra_p.Text = row.Cells[15].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_observacao_p.Text = row.Cells[13].Value.ToString();
            forminputeditarpatrimonio.Show();
        }
    }
}
