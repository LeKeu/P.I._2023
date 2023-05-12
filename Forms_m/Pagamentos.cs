using projeto_integrado.Classes;
using projeto_integrado.Forms_m_inputs;
using projeto_integrado.Forms_m_inputs_editar;
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

namespace projeto_integrado.Forms
{
    public partial class Pagamentos : Form
    {
        public static string id_pag;
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

        private void datagridview_pagamentos_m_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_pagamentos_m.Rows[indexRow];

            var forminputeditarpagamentos = new pagamentos_inputs_editar();

            for (int i = 0; i < row.Cells.Count; i++)
            {
                Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }

            id_pag = row.Cells[3].Value.ToString();

            forminputeditarpagamentos.input_editar_pagamento_nome_m.Text = row.Cells[3].Value.ToString();
            forminputeditarpagamentos.checkBox_editar_pagamento_janeiro_m.Checked = Convert.ToBoolean(row.Cells[30].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_fevereiro_m.Checked = Convert.ToBoolean(row.Cells[31].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_marco_m.Checked = Convert.ToBoolean(row.Cells[32].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_abril_m.Checked = Convert.ToBoolean(row.Cells[33].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_maio_m.Checked = Convert.ToBoolean(row.Cells[34].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_junho_m.Checked = Convert.ToBoolean(row.Cells[35].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_julho_m.Checked = Convert.ToBoolean(row.Cells[36].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_agosto_m.Checked = Convert.ToBoolean(row.Cells[37].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_setembro_m.Checked = Convert.ToBoolean(row.Cells[38].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_outubro_m.Checked = Convert.ToBoolean(row.Cells[39].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_novembro_m.Checked = Convert.ToBoolean(row.Cells[40].Value.ToString());
            forminputeditarpagamentos.checkBox_editar_pagamento_dezembro_m.Checked = Convert.ToBoolean(row.Cells[41].Value.ToString());
            
            forminputeditarpagamentos.Show();
        }
    }
}
