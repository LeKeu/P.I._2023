using projeto_integrado.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Forms_p_inputs
{
    public partial class produto_inputs : Form
    {
        public produto_inputs()
        {
            InitializeComponent();
        }

        private void btn_produto_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja enviar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                List<string> dados = new List<string>() { "ID - patrimonio produto", input_produto_descricaodetalhada_p.Text, input_produto_depreciacaoanual_p.Text, "ID - patrimonio grupo", input_produto_descricaoresumida_p.Text, input_produto_codproduto_p.Text, "ID - patrimonio fabricante", input_produto_modelo_p.Text, input_produto_vidautilanos_p.Text, checkBox_produto_ativo_p.Checked.ToString(), dateTimePicker_produto_ativo_p.Text };
                string nome_tabela = "PatrimonioProduto";

                //func p gravar os dados no json
                json_funcs.Convert_to_json(dados, nome_tabela, "J");

                this.Close();
            }
            else
            {

            }
        }
    }
}
