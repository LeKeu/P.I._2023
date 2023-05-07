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
    public partial class grupodebens_inputs : Form
    {
        public grupodebens_inputs()
        {
            InitializeComponent();
        }

        private void btn_grupobens_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja enviar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                List<string> dados = new List<string>() { "ID - Patrimonio grupo bens", input_grupobens_nome_p.Text, input_grupobens_identificador_p.Text, checkBox_grupobens_ativo_p.Checked.ToString() };
                string nome_tabela = "PatrimonioGrupoBens";

                //func p gravar os dados no json
                json_funcs.Convert_to_json(dados, nome_tabela, "D");

                this.Close();
            }
            else
            {

            }
        }
    }
}
