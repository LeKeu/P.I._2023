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
            //IMPORTANTE --> não adicionei o "celular" aqui!!!
            List<string> dados = new List<string>() { "ID-?", "ID-?DEP", input_dependente_nome_m.Text, "Foto", input_dependente_sexo_m.Text, input_dependente_datanasc_m.Text, input_dependente_parentesco_m.Text };
            string nome_tabela = "Dependente";

            //func p gravar os dados no json
            json_funcs.Convert_to_json(dados, nome_tabela, "G");
        }
    }
}
