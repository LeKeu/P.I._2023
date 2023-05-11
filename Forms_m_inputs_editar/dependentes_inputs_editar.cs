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
    public partial class dependentes_inputs_editar : Form
    {
        public dependentes_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_dependente_editar_m_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                
                var Dependentes = new Dependentes();
                string id_dep = Dependentes.id_dep;

                MemoryStream ms = new MemoryStream();
                Bitmap bmping = new Bitmap(img_editar_dependente.Image);
                bmping.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] photoData = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photoData, 0, photoData.Length);

                List<string> dados = new List<string>() { "ID-?", input_editar_dependente_nomemembrovinculado_m.Text, "ID-?DEP", input_editar_dependente_nome_m.Text, Convert.ToBase64String(photoData), input_editar_dependente_sexo_m.Text, dateTimePicker_editar_dependente_datanasc_m.Text, input_editar_dependente_parentesco_m.Text };

                var novo_json = json_funcs.UpdateValueJson("Dependente", "Nome", id_dep, dados);

                json_funcs.Update_Convert_to_json(novo_json);
                
                this.Close();
            }
            else
            {

            }
        }

        private void upload_img_dependente_Click(object sender, EventArgs e)
        {
            String imageLoc = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = dialog.FileName;
                    img_editar_dependente.ImageLocation = imageLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
