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
    public partial class setor_inputs : Form
    {
        public setor_inputs()
        {
            InitializeComponent();
        }

        private void btn_setor_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja enviar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string nome_tabela = "PatrimonioSetor";
                List<string> dados = new List<string>() { (json_funcs.Read_table(nome_tabela, "IdPatrimonioSetor")).ToString(), input_setor_nome_p.Text, checkBox_setor_ativo_p.Checked.ToString() };
                
                //func p gravar os dados no json
                json_funcs.Convert_to_json(dados, nome_tabela, "C");

                this.Close();
            }
            else
            {

            }
        }
    }
}
