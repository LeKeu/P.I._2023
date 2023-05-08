using projeto_integrado.Classes;
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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_produto_p.PerformClick();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            timer_produto_p.Start();
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

        private void btn_adicionar_produto_p_Click(object sender, EventArgs e)
        {
            var forminputproduto = new produto_inputs();
            forminputproduto.Show();
        }

        private void btn_invisivel_produto_p_Click(object sender, EventArgs e)
        {
            /*
             Parte que tira as colunas de outras tables
             */
            datagridview_produto_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_produto_p, "PatrimonioProduto", "J");

        }

        private void timer_produto_p_Tick(object sender, EventArgs e)
        {
            datagridview_produto_p.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_produto_p, "PatrimonioProduto", "J");
            timer_produto_p.Start();
        }

        private void datagridview_produto_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_produto_p.Rows[indexRow];

            for (int i = 0; i < row.Cells.Count; i++)
            {
                Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }

            var forminputeditarproduto = new produto_inputs_editar();
            forminputeditarproduto.input_editar_produto_depreciacaoanual_p.Text = row.Cells[47].Value.ToString();
            forminputeditarproduto.input_editar_produto_codproduto_p.Text = row.Cells[50].Value.ToString();
            forminputeditarproduto.input_editar_produto_modelo_p.Text = row.Cells[52].Value.ToString();
            forminputeditarproduto.input_editar_produto_vidautilanos_p.Text = row.Cells[53].Value.ToString();
            //forminputeditarproduto.dateTimePicker_editar_produto_datafimgarantia_p.Text = row.Cells[].Value.ToString();
            forminputeditarproduto.input_editar_produto_descricaoresumida_p.Text = row.Cells[49].Value.ToString();
            //forminputeditarproduto.checkBox_editar_produto_ativo_p.Checked = row.Cells[45].Value;
            forminputeditarproduto.input_editar_produto_descricaodetalhada_p.Text = row.Cells[46].Value.ToString();
            //forminputeditarproduto.img_editar_membro.Image = System.Drawing.Image.FromStream(new MemoryStream(Convert.FromBase64String(row.Cells[25].Value.ToString())));
            //Console.WriteLine("25--> "+row.Cells[25].Value.ToString());
            forminputeditarproduto.Show();
        }
    }
}
