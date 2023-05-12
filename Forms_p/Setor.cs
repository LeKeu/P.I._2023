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
    public partial class Setor : Form
    {
        public static string id_patset;
        public Setor()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_patrSetor_p.PerformClick();
        }

        private void Setor_Load(object sender, EventArgs e)
        {
            timer_patrSetor_p.Start();
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

        private void btn_adicionar_setor_p_Click(object sender, EventArgs e)
        {
            var forminputsetor = new setor_inputs();
            forminputsetor.Show();
        }

        private void btn_invisivel_patrSetor_p_Click(object sender, EventArgs e)
        {
            /*
             Parte que tira as colunas de outras tables
             */
            datagridview_setor_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_setor_p, "PatrimonioSetor", "C");

        }

        private void timer_patrSetor_p_Tick(object sender, EventArgs e)
        {
            datagridview_setor_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_setor_p, "PatrimonioSetor", "C");
            timer_patrSetor_p.Start();
        }

        private void datagridview_setor_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_setor_p.Rows[indexRow];

            id_patset = row.Cells[70].Value.ToString();

            var forminputeditarsetor = new setor_inputs_editar();

            for (int i = 0; i < row.Cells.Count; i++)
            {
                Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }

            forminputeditarsetor.input_editar_setor_nome_p.Text = row.Cells[70].Value.ToString();
            forminputeditarsetor.checkBox_editar_setor_ativo_p.Checked = Convert.ToBoolean(row.Cells[59].Value.ToString());
            forminputeditarsetor.Show();
        }
    }
}
