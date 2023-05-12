using Microsoft.Win32;
using projeto_integrado.Classes;
using projeto_integrado.Forms;
using projeto_integrado.Forms_p;
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

namespace projeto_integrado.Forms_p_inputs_editar
{
    public partial class setor_inputs_editar : Form
    {
        public setor_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_setor_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Setor = new Setor();
                string id_patset = Setor.id_patset;

                List<string> dados = new List<string>() { "ID - Patrimonio setor", input_editar_setor_nome_p.Text, checkBox_editar_setor_ativo_p.Checked.ToString() };

                var novo_json = json_funcs.UpdateValueJson("PatrimonioSetor", "NomeSetor", id_patset, dados);

                json_funcs.Update_Convert_to_json(novo_json);

                this.Close();
            }
            else
            {

            }
        }
    }
}
