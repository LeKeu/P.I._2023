using Newtonsoft.Json.Linq;
using projeto_integrado.Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_integrado.Forms_m_inputs
{
    public partial class membros_inputs : Form
    {
        public membros_inputs()
        {
            InitializeComponent();
        }

        private void btn_membro_enviar_m_Click(object sender, EventArgs e)
        {
            

            //conexao_api.AddRow("Membro", new List<object>() { input_membro_matricula_m.Text, input_membro_nome_m.Text, input_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, input_membro_datainclusao_m.Text, input_membro_sexo_m.Text });
        }

        private void upload_img_membro_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_membro_enviar_m_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja enviar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MemoryStream ms = new MemoryStream();
                Bitmap bmping = new Bitmap(img_membro.Image);
                bmping.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] photoData = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photoData, 0, photoData.Length);

                string nome_tabela = "Membro";
                List<string> dados = new List<string>() { (json_funcs.Read_table(nome_tabela, "IdMembro")).ToString(), input_membro_matricula_m.Text, input_membro_nome_m.Text, dateTimePicker_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, dateTimePicker_membro_datainclusao_m.Text, input_membro_sexo_m.Text, checkbox_membro_status_m.Checked.ToString(), "corrdenadora", "datasaida", "assmembro", "asscorrdsocial", "asscorrdadm", "asscoordfinanc", Convert.ToBase64String(photoData) }; 
                

                //func p gravar os dados no json
                json_funcs.Convert_to_json(dados, nome_tabela, "Y");

                //conexao_api.AddRow("Membro", "Y", new List<object>() { input_membro_matricula_m.Text, input_membro_nome_m.Text, dateTimePicker_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, dateTimePicker_membro_datainclusao_m.Text, input_membro_sexo_m.Text });



                this.Close();
            }
            else
            {

            }
        }

        private void upload_img_membro_Click_1(object sender, EventArgs e)
        {
            String imageLoc = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = dialog.FileName;
                    img_membro.ImageLocation = imageLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
