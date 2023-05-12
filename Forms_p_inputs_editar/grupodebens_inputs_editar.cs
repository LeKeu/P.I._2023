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
    public partial class grupodebens_inputs_editar : Form
    {
        public grupodebens_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_grupobens_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Grupo_De_Bens = new Grupo_de_bens();
                string id_patgb = Grupo_de_bens.id_patgb;

                List<string> dados = new List<string>() { "ID - Patrimonio grupo bens", input_editar_grupobens_nome_p.Text, input_editar_grupobens_identificador_p.Text, checkBox_editar_grupobens_ativo_p.Checked.ToString() };

                var novo_json = json_funcs.UpdateValueJson("PatrimonioGrupoBens", "IdentificadorGrupoBens", id_patgb, dados);

                json_funcs.Update_Convert_to_json(novo_json);

                this.Close();
            }
            else
            {

            }
        }
    }
}
