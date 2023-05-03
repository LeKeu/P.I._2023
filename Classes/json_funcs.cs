using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_integrado.Classes
{
    internal class json_funcs
    {
        public static void Convert_to_json(List<string> dados, string nome_tabela, string ultima_coluna)
        {
            // path do arquivo json, onde será guardado as informações
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE.json";
            // ler todos os dados que o arq contém
            var jsonData = System.IO.File.ReadAllText(arq_path);
            // des-serializar o arquivo e guardar em uma lista
            var dados_salvos = JsonConvert.DeserializeObject<List<object>>(jsonData);

            // dicionário para conter os dados recebidos dos inputs em suas respectivas colunas
            Dictionary<string, string> dict_dados = new Dictionary<string, string>();

            // retornando o nome das colunas da tabela específica
            var values_colunas = conexao_api.ReadTableColumnName(nome_tabela, ultima_coluna);
            dict_dados.Add("Tabela", nome_tabela);
            foreach (var row in values_colunas)
            {
                for (int i = 0; i < row.Count; i++)
                {
                    //adicionando no dict a chave com seu valor
                    dict_dados.Add((string)row[i], dados[i]);
                }
            }


            // adicionar, no arq des-serializado os dados recentes
            dados_salvos.Add(dict_dados);
            // serializar o arq novo para salvar novamente
            var json_arq = JsonConvert.SerializeObject(dados_salvos);
            System.IO.File.WriteAllText(arq_path, json_arq);

            
            if (System.IO.File.Exists(arq_path) == false)
            {
                Console.Write("Inserir aqui o código para criar o arquivo caso não exista");
            }
            
        }

        public static DataTable Read_from_json()  // lendo do arq json criado
        {
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\JSONTESTE.json";  // pegar caminho automatico!
            List<string> dict_dados_leitura = new List<string>();

            dynamic jsonArq = JsonConvert.DeserializeObject(File.ReadAllText(arq_path), (typeof(DataTable)));
            Console.WriteLine(jsonArq.GetType());

            return jsonArq;


        }
    }
}
