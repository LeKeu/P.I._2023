using Microsoft.Win32;
using projeto_integrado.Classes;
using projeto_integrado.Forms;
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

namespace projeto_integrado.Forms_m_inputs_editar
{
    public partial class membros_inputs_editar : Form
    {
        public membros_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_membro_editar_m_Click(object sender, EventArgs e)
        {
            
        }

        private void upload_img_editar_membro_editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editar_membro_enviar_m_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Membros = new Membros();
                string id_membro = Membros.id_membro;

                MemoryStream ms = new MemoryStream();
                Bitmap bmping = new Bitmap(img_editar_membro.Image);
                bmping.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] photoData = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photoData, 0, photoData.Length);

                List<string> dados = new List<string>() { "ID-?", input_editar_membro_matricula_m.Text, input_editar_membro_nome_m.Text, dateTimePicker_editar_membro_datanasc_m.Text, input_editar_membro_cpf_m.Text, input_editar_membro_rg_m.Text, input_editar_membro_celular_m.Text, input_editar_membro_email_m.Text, input_editar_membro_filiacao_m.Text, input_editar_membro_enderresidencial_m.Text, input_editar_membro_profissao_m.Text, input_editar_membro_endercomercial_m.Text, input_editar_membro_estadocivil_m.Text, input_editar_membro_conjuge_m.Text, input_editar_membro_localinclusao_m.Text, dateTimePicker_editar_membro_datainclusao_m.Text, input_editar_membro_sexo_m.Text, input_editar_membro_status_m.Text, "corrdenadora", "datasaida", "assmembro", "asscorrdsocial", "asscorrdadm", "asscoordfinanc", Convert.ToBase64String(photoData) };

                var novo_json = json_funcs.UpdateValueJson("Membro", "CPF", id_membro, dados);
                
                json_funcs.Update_Convert_to_json(novo_json);

                this.Close();
            }
            else
            {

            }
        }

        private void upload_editar_img_membro_Click(object sender, EventArgs e)
        {
            String imageLoc = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = dialog.FileName;
                    img_editar_membro.ImageLocation = imageLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deletar_membro_m_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja DELETAR essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Membros = new Membros();
                string id_membro = Membros.id_membro;

                var novo_json = json_funcs.DeleteValueJson("Membro", "CPF", id_membro);

                json_funcs.Update_Convert_to_json(novo_json);
                this.Close();
            }
            else
            {

            }
            
        }
    }
}
