using Microsoft.Win32;
using projeto_integrado.Classes;
using projeto_integrado.Forms;
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

namespace projeto_integrado.Forms_m_inputs_editar
{
    public partial class pagamentos_inputs_editar : Form
    {
        public pagamentos_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_pagamentos_enviar_m_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Pagamentos = new Pagamentos();
                string id_pag = Pagamentos.id_pag;

                List<string> dados = new List<string>() { "ID-?", input_editar_pagamento_nome_m.Text, checkBox_editar_pagamento_janeiro_m.Checked.ToString(),
                    checkBox_editar_pagamento_fevereiro_m.Checked.ToString(), checkBox_editar_pagamento_marco_m.Checked.ToString(), checkBox_editar_pagamento_abril_m.Checked.ToString(), checkBox_editar_pagamento_maio_m.Checked.ToString(), checkBox_editar_pagamento_junho_m.Checked.ToString(),
                    checkBox_editar_pagamento_julho_m.Checked.ToString(), checkBox_editar_pagamento_agosto_m.Checked.ToString(), checkBox_editar_pagamento_setembro_m.Checked.ToString(),
                    checkBox_editar_pagamento_outubro_m.Checked.ToString(), checkBox_editar_pagamento_novembro_m.Checked.ToString(), checkBox_editar_pagamento_dezembro_m.Checked.ToString() };

                var novo_json = json_funcs.UpdateValueJson("ListaPagamento", "Nome", id_pag, dados);

                json_funcs.Update_Convert_to_json(novo_json);

                this.Close();
            }
            else
            {

            }
        }
    }
}
