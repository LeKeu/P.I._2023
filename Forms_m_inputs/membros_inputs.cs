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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_integrado.Forms_m_inputs
{
    public partial class membros_inputs : Form
    {
        public membros_inputs()
        {
            InitializeComponent();
        }

        private void btn_membro_enviar_m_Click(object sender, EventArgs e)
        {
            //conexao_api.AddRow("Membro", new List<object>() { input_membro_matricula_m.Text, input_membro_nome_m.Text, input_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, input_membro_datainclusao_m.Text, input_membro_sexo_m.Text });
            
            //json_funcs.Convert_to_json(new List<object>() { input_membro_matricula_m.Text, input_membro_nome_m.Text, input_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, input_membro_datainclusao_m.Text, input_membro_sexo_m.Text });
            //json_funcs.Read_from_json(new List<object>() { input_membro_matricula_m.Text, input_membro_nome_m.Text, input_membro_datanasc_m.Text, input_membro_cpf_m.Text, input_membro_rg_m.Text, input_membro_celular_m.Text, input_membro_email_m.Text, input_membro_filiacao_m.Text, input_membro_enderresidencial_m.Text, input_membro_profissao_m.Text, input_membro_endercomercial_m.Text, input_membro_estadocivil_m.Text, input_membro_conjuge_m.Text, input_membro_localinclusao_m.Text, input_membro_datainclusao_m.Text, input_membro_sexo_m.Text });
        }
    }
}
