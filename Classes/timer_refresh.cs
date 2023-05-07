using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Classes
{
    internal class timer_refresh
    {
        public static void refreshReg( DataGridView datagridview, string nome_tabela, string ultima_coluna )
        {
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var values_colunas = json_funcs.ColumnName(nome_tabela);

            for (int i = 0; i < datagridview.Rows.Count - 1; i++)
            {

                var row = datagridview.Rows[i];

                if (row.Cells[0].Value.ToString() != nome_tabela)
                {
                    datagridview.CurrentCell = null;
                    row.Visible = false;
                    row.Selected = false;
                }
            }

            for (int i = 0; i < datagridview.Columns.Count; i++)
            {
                datagridview.Columns[i].Visible = false;
            }

            foreach (var coluna in values_colunas)
            {
                for (int i = 0; i < coluna.Count; i++)
                {
                    datagridview.Columns[(string)coluna[i]].Visible = true;

                }
            }
        }
    }

}
