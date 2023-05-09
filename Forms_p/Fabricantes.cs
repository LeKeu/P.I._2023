using projeto_integrado.Classes;
using projeto_integrado.Forms_p_inputs;
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
    }
}
