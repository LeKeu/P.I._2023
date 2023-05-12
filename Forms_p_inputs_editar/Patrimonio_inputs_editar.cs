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
    public partial class Patrimonio_inputs_editar : Form
    {
        public Patrimonio_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_patrimonio_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Patrimônio = new Patrimônio();
                string id_pat = Patrimônio.id_pat;

                List<string> dados = new List<string>() { "ID-?", input_editar_patrimonio_numpat_p.Text, input_editar_patrimonio_numserie_p.Text, input_editar_patrimonio_notafiscal_p.Text, dateTimePicker_editar_patrimonio_datacompra_p.Text, dateTimePicker_editar_patrimonio_fimgarantia_p.Text, input_editar_patrimonio_valorbem_p.Text, input_editar_patrimonio_estadoconservacao_p.Text, input_editar_patrimonio_valoratual_p.Text, "ID patrimonio setor", "ID patrimonio produto", "ID membro responsavel", "ID patrimonio fornecedor", input_editar_patrimonio_observacao_p.Text, input_editar_patrimonio_status_p.Text, input_editar_patrimonio_ordemcompra_p.Text };

                var novo_json = json_funcs.UpdateValueJson("Patrimonio", "NumeroPat", id_pat, dados);

                json_funcs.Update_Convert_to_json(novo_json);

                this.Close();
            }
            else
            {

            }
        }

        private void btn_patrimonio_deletar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja DELETAR essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Patrimônio = new Patrimônio();
                string id_pat = Patrimônio.id_pat;

                var novo_json = json_funcs.DeleteValueJson("Patrimonio", "NumeroPat", id_pat);

                json_funcs.Update_Convert_to_json(novo_json);
                this.Close();
            }
        }
    }
}
