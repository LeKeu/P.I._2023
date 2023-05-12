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
    public partial class fornecedor_inputs_editar : Form
    {
        public fornecedor_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_fornecedor_enviar_p_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var Fornecedor = new Fornecedor();
                string id_patfor = Fornecedor.id_patfor;

                List<string> dados = new List<string>() { "ID - Patrimonio fornecedor", input_editar_fornecedor_nome_p.Text, input_editar_fornecedor_cnpj_p.Text, checkBox_editar_fornecedor_ativo_p.Checked.ToString() };

                var novo_json = json_funcs.UpdateValueJson("PatrimonioFornecedor", "CNPJ", id_patfor, dados);

                json_funcs.Update_Convert_to_json(novo_json);

                this.Close();
            }
            else
            {

            }
        }
    }
}
