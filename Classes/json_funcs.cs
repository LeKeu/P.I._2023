using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_integrado.Classes
{
    internal class json_funcs
    {
        public static void Convert_to_json(List<object> values)
        {

            string arq_path = @"C:\Users\Lenovo\Desktop\JSONTESTE.json";

            // ler todos os dados que o arq contém
            var jsonData = System.IO.File.ReadAllText(arq_path);

            // des-serializar o arquivo e guardar em uma lista
            var dados_salvos = JsonConvert.DeserializeObject<List<object>>(jsonData);

            // adicionar, no arq des-serializado os dados recentes
            dados_salvos.Add(values);

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
            string arq_lido = System.IO.File.ReadAllText(arq_path);  // leitura do arq

            var nsei = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(arq_lido);

            foreach (object o in nsei)
            {
                Console.WriteLine(o.ToString());
            }

            //return(nsei);
            
        }
    }
}
