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
    public partial class pagamentos_inputs : Form
    {
        public pagamentos_inputs()
        {
            InitializeComponent();
        }

        private void btn_pagamentos_enviar_m_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja enviar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                List<string> dados = new List<string>() { "ID-?", input_pagamento_nome_m.Text, checkBox_pagamento_janeiro_m.Checked.ToString(), 
                    checkBox_pagamento_fevereiro_m.Checked.ToString(), checkBox_pagamento_marco_m.Checked.ToString(), checkBox_pagamento_abril_m.Checked.ToString(), checkBox_pagamento_maio_m.Checked.ToString(), checkBox_pagamento_junho_m.Checked.ToString(), 
                    checkBox_pagamento_julho_m.Checked.ToString(), checkBox_pagamento_agosto_m.Checked.ToString(), checkBox_pagamento_setembro_m.Checked.ToString(), 
                    checkBox_pagamento_outubro_m.Checked.ToString(), checkBox_pagamento_novembro_m.Checked.ToString(), checkBox_pagamento_dezembro_m.Checked.ToString() };

                string nome_tabela = "ListaPagamento";

                //func p gravar os dados no json
                json_funcs.Convert_to_json(dados, nome_tabela, "O");

                this.Close();
            }
            else
            {

            }
        }

        private void pagamentos_inputs_Load(object sender, EventArgs e)
        {
            input_pagamento_nome_m.AutoCompleteCustomSource.Clear();
            List<string> valores = json_funcs.ReadTableRowValue("Membro", "Nome");

            string[] arrayt = valores.ToArray();

            input_pagamento_nome_m.AutoCompleteCustomSource.AddRange(arrayt);
        }
    }
}
