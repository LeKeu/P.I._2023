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
                //List<string> dados = new List<string>() { "ID-?", input_pagamento_nome_m.Text, input_pagamento_valor_m.Text, "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
                //string nome_tabela = "ListaPagamento";

                //func p gravar os dados no json
                //json_funcs.Convert_to_json(dados, nome_tabela, "O");

                this.Close();
            }
            else
            {

            }
        }
    }
}
