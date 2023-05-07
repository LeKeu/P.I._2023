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

namespace projeto_integrado.Forms_m_inputs_editar
{
    public partial class membros_inputs_editar : Form
    {
        public membros_inputs_editar()
        {
            InitializeComponent();
        }

        private void btn_editar_membro_editar_m_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que deseja editar essas informações?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //List<string> dados = new List<string>() { "ID-?", input_membro_matricula_m.Text, input_membro_nome_m.Text, dateTimePicker_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, dateTimePicker_membro_datainclusao_m.Text, input_membro_sexo_m.Text, input_membro_status_m.Text, "corrdenadora", "datasaida", "assmembro", "asscorrdsocial", "asscorrdadm", "asscoordfinanc", "fotomembro" };
                //string nome_tabela = "Membro";

                //func p gravar os dados no json
                //json_funcs.Convert_to_json(dados, nome_tabela, "Y");

                //conexao_api.AddRow("Membro", "Y", new List<object>() { input_membro_matricula_m.Text, input_membro_nome_m.Text, dateTimePicker_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, dateTimePicker_membro_datainclusao_m.Text, input_membro_sexo_m.Text });



                this.Close();
            }
            else
            {

            }
        }
    }
}
