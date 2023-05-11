using projeto_integrado.Classes;
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
    public partial class Fabricantes : Form
    {
        public static string id_fabr;
        public Fabricantes()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_patrFabr_p.PerformClick();
        }

        private void Fabricantes_Load(object sender, EventArgs e)
        {
            timer_patrFabr_p.Start();
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

        private void btn_adicionar_fabricantes_p_Click(object sender, EventArgs e)
        {
            var forminputfabricante = new fabricante_inputs();
            forminputfabricante.Show();
        }

        private void btn_invisivel_patrFabr_p_Click(object sender, EventArgs e)
        {
            /*
         Parte que tira as colunas de outras tables
         */
            datagridview_fabricantes_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_fabricantes_p, "PatrimonioFabricante", "C");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datagridview_fabricantes_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_fabricantes_p, "PatrimonioFabricante", "C");
            timer_patrFabr_p.Start();

        }

        private void datagridview_fabricantes_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_fabricantes_p.Rows[indexRow];

            var forminputeditarfabricantes = new fabricante_inputs_editar();

            id_fabr = row.Cells[59].Value.ToString();

            for (int i = 0; i < row.Cells.Count; i++)
            {
                //Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }

            forminputeditarfabricantes.input_editar_fabricante_nome_p.Text = row.Cells[59].Value.ToString();
            //forminputeditarfabricantes.checkBox_editar_fabricante_ativo_p.Text = row.Cells[60].Value.ToString();
            //Console.WriteLine("25--> "+row.Cells[25].Value.ToString());
            forminputeditarfabricantes.Show();
        }
    }
}
