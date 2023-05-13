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
    public partial class patrimonio_inputs : Form
    {
        public patrimonio_inputs()
        {
            InitializeComponent();
        }

        private void btn_patrimonio_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja enviar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string nome_tabela = "Patrimonio";
                List<string> dados = new List<string>() { (json_funcs.Read_table(nome_tabela, "IdPatrimonio")).ToString(), input_patrimonio_numpat_p.Text, input_patrimonio_numserie_p.Text, input_patrimonio_notafiscal_p.Text, dateTimePicker_patrimonio_datacompra_p.Text, dateTimePicker_patrimonio_fimgarantia_p.Text, input_patrimonio_valorbem_p.Text, input_patrimonio_estadoconservacao_p.Text, input_patrimonio_valoratual_p.Text, "ID patrimonio setor", "ID patrimonio produto", "ID membro responsavel", "ID patrimonio fornecedor", input_patrimonio_observacao_p.Text, input_patrimonio_status_p.Text, input_patrimonio_ordemcompra_p.Text };
                
                //func p gravar os dados no json
                json_funcs.Convert_to_json(dados, nome_tabela, "P");

                this.Close();
            }
            else
            {

            }
        }
    }
}
