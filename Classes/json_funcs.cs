using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_integrado.Classes
{
    internal class json_funcs
    {
        public static void Convert_to_json(List<string> dados, string nome_tabela)
        {

            string arq_path = @"C:\Users\Lenovo\Desktop\JSONTESTE.json";
            // ler todos os dados que o arq contém
            var jsonData = System.IO.File.ReadAllText(arq_path);
            // des-serializar o arquivo e guardar em uma lista
            var dados_salvos = JsonConvert.DeserializeObject<List<object>>(jsonData);

            Dictionary<string, string> dict_dados = new Dictionary<string, string>();

            var values_colunas = conexao_api.ReadTableColumnName("Membro");
            dict_dados.Add("Tabela", "Membro");
            foreach (var row in values_colunas)
            {
                for (int i = 0; i < row.Count; i++)
                {
                    dict_dados.Add((string)row[i], dados[i]);
                }
            }


            // adicionar, no arq des-serializado os dados recentes
            dados_salvos.Add(dict_dados);
            // serializar o arq novo para salvar novamente
            var json_arq = JsonConvert.SerializeObject(dados_salvos);
            System.IO.File.WriteAllText(arq_path, json_arq);

            /*
            if (System.IO.File.Exists(arq_path) == false)
            {
                
            }
            else
            {
                Console.Write("aiiaiaiia");
            }
            */
        }

        public static void Read_from_json()  // lendo do arq json criado
        {
            string arq_path = @"C:\Users\Lenovo\Desktop\JSONTESTE.json";  // pegar caminho automatico!
            
            dynamic jsonArq = JsonConvert.DeserializeObject(File.ReadAllText(arq_path));
            List<object> aaa = new List<object>();

            Console.WriteLine(jsonArq.Count);
            foreach ( var item in jsonArq )
            {
                aaa.Add(item);
            }

            Console.WriteLine(aaa[0]);
            Console.WriteLine(aaa[1]);

            Console.WriteLine(aaa[2].GetType());

            //return(nsei);

        }
    }
}
