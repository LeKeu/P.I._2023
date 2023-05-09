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
                //IMPORTANTE --> não adicionei o "celular" aqui!!!
                List<string> dados = new List<string>() { "ID-?", input_dependente_nomemembrovinculado_m.Text, "ID-?DEP", input_dependente_nome_m.Text, "Foto", input_dependente_sexo_m.Text, dateTimePicker_dependente_datanasc_m.Text, input_dependente_parentesco_m.Text };
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
            //o que era pra ser aqui?32
        }

        private void dependentes_inputs_Load(object sender, EventArgs e)
        {
            input_dependente_nomemembrovinculado_m.AutoCompleteCustomSource.Clear();
            List<string> valores = json_funcs.ReadTableRowValue("Membro", "Nome");

            string[] arrayt = valores.ToArray();

            input_dependente_nomemembrovinculado_m.AutoCompleteCustomSource.AddRange(arrayt);
        }
    }
}
