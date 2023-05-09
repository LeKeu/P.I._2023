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
    public partial class Pagamentos : Form
    {
        public Pagamentos()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_memListPag_m.PerformClick();
        }

        private void Pagamentos_Load(object sender, EventArgs e)
        {
            timer_listaPag_m.Start();
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

        private void btn_adicionar_pagamentos_m_Click(object sender, EventArgs e)
        {
            var forminputpagementos = new pagamentos_inputs();
            forminputpagementos.Show();
        }

        private void btn_invisivel_memListPag_m_Click(object sender, EventArgs e)
        {
            /*
             Parte que tira as colunas de outras tables
             */
            datagridview_pagamentos_m.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_pagamentos_m, "ListaPagamento", "O");

        }

        private void timer_listaPag_m_Tick(object sender, EventArgs e)
        {
            datagridview_pagamentos_m.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_pagamentos_m, "ListaPagamento", "O");
            timer_listaPag_m.Start();
        }
    }
}
