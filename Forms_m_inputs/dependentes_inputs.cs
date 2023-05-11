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

namespace projeto_integrado.Forms_m_inputs
{
    public partial class dependentes_inputs : Form
    {
        public dependentes_inputs()
        {
            InitializeComponent();
        }

        private void btn_dependente_enviar_m_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja enviar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MemoryStream ms = new MemoryStream();
                Bitmap bmping = new Bitmap(img_dependente.Image);
                bmping.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] photoData = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photoData, 0, photoData.Length);
                //IMPORTANTE --> não adicionei o "celular" aqui!!!
                List<string> dados = new List<string>() { "ID-?", input_dependente_nomemembrovinculado_m.Text, "ID-?DEP", input_dependente_nome_m.Text, Convert.ToBase64String(photoData), input_dependente_sexo_m.Text, dateTimePicker_dependente_datanasc_m.Text, input_dependente_parentesco_m.Text };
                string nome_tabela = "Dependente";

                //func p gravar os dados no json
                json_funcs.Convert_to_json(dados, nome_tabela, "G");

                this.Close();
            }
            else
            {

            }
        }

        private void input_dependente_nomemembrovinculado_m_TextChanged(object sender, EventArgs e)
        {
        }

        private void dependentes_inputs_Load(object sender, EventArgs e)
        {
            input_dependente_nomemembrovinculado_m.AutoCompleteCustomSource.Clear();
            List<string> valores = json_funcs.ReadTableRowValue("Membro", "Nome");

            string[] arrayt = valores.ToArray();

            input_dependente_nomemembrovinculado_m.AutoCompleteCustomSource.AddRange(arrayt);
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
                    img_dependente.ImageLocation = imageLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
