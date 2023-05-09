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
    public partial class Grupo_de_bens : Form
    {
        public Grupo_de_bens()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_patriGrBens_p.PerformClick();
        }

        private void Grupo_de_bens_Load(object sender, EventArgs e)
        {
            timer_patriGrpBens_p.Start();
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

        private void btn_adicionar_grupo_de_bens_p_Click(object sender, EventArgs e)
        {
            var forminputgrupobens = new grupodebens_inputs();
            forminputgrupobens.Show();
        }

        private void btn_invisivel_patriGrBens_p_Click(object sender, EventArgs e)
        {
            /*
         Parte que tira as colunas de outras tables
         */
            datagridview_grupo_de_bens_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_grupo_de_bens_p, "PatrimonioGrupoBens", "D");

        }

        private void datagridview_grupo_de_bens_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_grupo_de_bens_p.Rows[indexRow];

            var forminputeditargrupodebens = new grupodebens_inputs_editar();

            for (int i = 0; i < row.Cells.Count; i++)
            {
                Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }

            forminputeditargrupodebens.input_editar_grupobens_nome_p.Text = row.Cells[62].Value.ToString();
            forminputeditargrupodebens.input_editar_grupobens_identificador_p.Text = row.Cells[63].Value.ToString();
            forminputeditargrupodebens.checkBox_editar_grupobens_ativo_p.Text = row.Cells[60].Value.ToString();
            //Console.WriteLine("25--> "+row.Cells[25].Value.ToString());
            forminputeditargrupodebens.Show();
        }
    }
}
