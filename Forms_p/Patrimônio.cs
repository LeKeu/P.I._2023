using projeto_integrado.Classes;
using projeto_integrado.Forms_m_inputs;
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
    }
}
