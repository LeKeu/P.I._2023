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
            //datagridview_patrimonio_p.DataSource = json_funcs.Read_from_json_datagridview();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_patrimonio_m.PerformClick();
        }

        private void Patrimônio_Load(object sender, EventArgs e)
        {
            timer_patrimonio_p.Start();
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

        private void timer_patrimonio_p_Tick(object sender, EventArgs e)
        {
            datagridview_patrimonio_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_patrimonio_p, "Patrimonio", "P");
            timer_patrimonio_p.Start();
        }

        private void datagridview_patrimonio_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_patrimonio_p.Rows[indexRow];

            Console.WriteLine("eu odeio isso");

            for (int i = 0; i < row.Cells.Count; i++)
            {
                Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }

            var forminputeditarpatrimonio = new Patrimonio_inputs_editar();
            forminputeditarpatrimonio.input_editar_patrimonio_numpat_p.Text = row.Cells[44].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_numserie_p.Text = row.Cells[45].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_notafiscal_p.Text = row.Cells[46].Value.ToString();
            forminputeditarpatrimonio.dateTimePicker_editar_patrimonio_datacompra_p.Text = row.Cells[47].Value.ToString();
            forminputeditarpatrimonio.dateTimePicker_editar_patrimonio_fimgarantia_p.Text = row.Cells[48].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_valorbem_p.Text = row.Cells[49].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_estadoconservacao_p.Text = row.Cells[50].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_valoratual_p.Text = row.Cells[51].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_status_p.Text = row.Cells[18].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_ordemcompra_p.Text = row.Cells[57].Value.ToString();
            forminputeditarpatrimonio.input_editar_patrimonio_observacao_p.Text = row.Cells[56].Value.ToString();
            forminputeditarpatrimonio.Show();
        }

        /*
        public static T ConvertFromDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }
        */
    }
}
