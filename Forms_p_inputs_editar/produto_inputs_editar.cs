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
    public partial class produto_inputs_editar : Form
    {
        public produto_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_produto_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Produto = new Produto();
                string id_patpr = Produto.id_patpr;

                List<string> dados = new List<string>() { "ID - patrimonio produto", input_editar_produto_descricaodetalhada_p.Text, input_editar_produto_depreciacaoanual_p.Text, "ID - patrimonio grupo", input_editar_produto_descricaoresumida_p.Text, input_editar_produto_codproduto_p.Text, "ID - patrimonio fabricante", input_editar_produto_modelo_p.Text, input_editar_produto_vidautilanos_p.Text, checkBox_editar_produto_ativo_p.Checked.ToString(), dateTimePicker_editar_produto_datafimgarantia_p.Text };

                var novo_json = json_funcs.UpdateValueJson("PatrimonioProduto", "CodigoProduto", id_patpr, dados);

                json_funcs.Update_Convert_to_json(novo_json);

                this.Close();
            }
            else
            {

            }
        }

        private void btn_produto_deletar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja DELETAR essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Produto = new Produto();
                string id_patpr = Produto.id_patpr;

                var novo_json = json_funcs.DeleteValueJson("PatrimonioProduto", "CodigoProduto", id_patpr);

                json_funcs.Update_Convert_to_json(novo_json);
                this.Close();
            }
        }
    }
}
