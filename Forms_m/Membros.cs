using projeto_integrado.Classes;
using projeto_integrado.Forms_m_inputs;
using projeto_integrado.Forms_m_inputs_editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Forms
{
    public partial class Membros : Form
    {
        public static string id_membro;
        public Membros()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btn_invisivel_membros_m.PerformClick();
        }

        private void Membros_Load_1(object sender, EventArgs e)
        {
            timer_membro_m.Start();
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

        private void btn_adicionar_membros_m_Click(object sender, EventArgs e)
        {
            var forminputmembros = new membros_inputs();
            forminputmembros.Show();
        }

        private void btn_invisivel_membros_m_Click(object sender, EventArgs e)
        {
            /*
             Parte que tira as colunas de outras tables
             */
            datagridview_membros_m.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_membros_m, "Membro", "Y");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datagridview_membros_m.DataSource = json_funcs.Read_from_json_datagridview();
            timer_refresh.refreshReg(datagridview_membros_m, "Membro", "Y");
            timer_membro_m.Start();
        }

        private void datagridview_membros_m_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int indexRow = e.RowIndex;
            DataGridViewRow row = datagridview_membros_m.Rows[indexRow];

            id_membro = row.Cells[5].Value.ToString();  // pegando o CPF

            for (int i = 0; i < row.Cells.Count; i++)
            {
                Console.WriteLine(i + "lolo --> " + row.Cells[i].Value);
            }

            var forminputeditarmembros = new membros_inputs_editar();
            forminputeditarmembros.input_editar_membro_nome_m.Text = row.Cells[3].Value.ToString();
            forminputeditarmembros.input_editar_membro_matricula_m.Text = row.Cells[2].Value.ToString();
            forminputeditarmembros.dateTimePicker_editar_membro_datanasc_m.Text = row.Cells[4].Value.ToString();
            forminputeditarmembros.input_editar_membro_cpf_m.Text = row.Cells[5].Value.ToString();
            forminputeditarmembros.input_editar_membro_rg_m.Text = row.Cells[6].Value.ToString();
            forminputeditarmembros.input_editar_membro_celular_m.Text = row.Cells[7].Value.ToString();
            forminputeditarmembros.input_editar_membro_email_m.Text = row.Cells[8].Value.ToString();
            forminputeditarmembros.input_editar_membro_filiacao_m.Text = row.Cells[9].Value.ToString();
            forminputeditarmembros.input_editar_membro_profissao_m.Text = row.Cells[11].Value.ToString();
            forminputeditarmembros.input_editar_membro_sexo_m.Text = row.Cells[17].Value.ToString();
            forminputeditarmembros.input_editar_membro_enderresidencial_m.Text = row.Cells[10].Value.ToString();
            forminputeditarmembros.input_editar_membro_endercomercial_m.Text = row.Cells[12].Value.ToString();
            forminputeditarmembros.input_editar_membro_estadocivil_m.Text = row.Cells[13].Value.ToString();
            forminputeditarmembros.input_editar_membro_conjuge_m.Text = row.Cells[14].Value.ToString();
            forminputeditarmembros.input_editar_membro_localinclusao_m.Text = row.Cells[15].Value.ToString();
            forminputeditarmembros.dateTimePicker_editar_membro_datainclusao_m.Text = row.Cells[16].Value.ToString();
            forminputeditarmembros.checkbox_editar_membro_status_m.Checked = Convert.ToBoolean(row.Cells[18].Value.ToString());
            forminputeditarmembros.input_editar_membro_coordenadora_m.Text = row.Cells[19].Value.ToString();
            forminputeditarmembros.input_editar_membro_datadesaida_m.Text = row.Cells[20].Value.ToString();
            forminputeditarmembros.img_editar_membro.Image = System.Drawing.Image.FromStream(new MemoryStream(Convert.FromBase64String(row.Cells[25].Value.ToString())));
            //Console.WriteLine("25--> "+row.Cells[25].Value.ToString());
            forminputeditarmembros.Show();
        }

        private void datagridview_membros_m_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
