using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_integrado.Classes
{
    internal class conexao_api
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "GRP-MMIB";
        static readonly string SpreadsheetId = "1OYojwhnlzXB0kaJNVM1dsZrUUlRdlpS2OSzuVassbN0";
        static SheetsService service;
        static Dictionary<string, string> colunas_paginas = new Dictionary<string, string> ();

        public static void Init()
        {
            colunas_paginas.Add("Membro", "Y");
            colunas_paginas.Add("Dependente", "G");
            colunas_paginas.Add("ListaPagamento", "O");
            colunas_paginas.Add("Patrimonio", "P");
            colunas_paginas.Add("PatrimonioFabricante", "C");
            colunas_paginas.Add("PatrimonioGrupoBens", "D");
            colunas_paginas.Add("PatrimonioProduto", "J");
            colunas_paginas.Add("PatrimonioSetor", "C");
            colunas_paginas.Add("PatrimonioFornecedor", "D");


            GoogleCredential credential;

            //Lendo as credencias do arquivo
            using (var stream = new FileStream("chave_credenciais.json", FileMode.Open, FileAccess.Read)) // ou chvae_coisa_servico
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Criando o serviço do Google Planilhas API
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        static void ReadSheet(string sheet, string ultima_coluna) // STRING OU static readonly string??
        {

            // Especificando o range da coluna
            var range = $"{sheet}!A:{ultima_coluna}";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            // Ecevutando a operação de Read
            var response = request.Execute();

            // Pegando todos os valores das colunas especificadas
            IList<IList<object>> values = response.Values;

            if (values != null && values.Count > 0)
            {
                Console.WriteLine("DATA FOUND");
                /*
                var json_arq = Newtonsoft.Json.JsonConvert.SerializeObject(values);
                string arq_path = @"C:\Users\Lenovo\Desktop\aaa\JSONTESTE.json";
                if (System.IO.File.Exists(arq_path) == false)
                {
                    System.IO.File.WriteAllText(arq_path, json_arq);
                }
                else
                {
                    Console.Write("aiiaiaiia");
                }
                */
                /*
                foreach (var row in values)
                {
                    // Writing Data on Console...
                    Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", row[0], row[1], row[2], row[3], row[4]);
                }
                */
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        public static IList<IList<object>> ReadTableColumnName(string sheet, string ultima_coluna)
        {
            // Especificando o range da coluna. Se eu quiser todos os dados das colunas, eu não adiciono a linha 
            var range = $"{sheet}!A1:{ultima_coluna}1";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            // Executando a operação de Read
            var response = request.Execute();

            // Pegando todos os valores das colunas especificadas
            IList<IList<object>> values = response.Values;

            if (values != null && values.Count > 0)
            {
                Console.WriteLine("DATA FOUND");
                /*
                for(int i = 0; i < values.Count; i++)
                {
                    string items = string.Join(Environment.NewLine, values[i]);

                    Console.WriteLine(items);
                }
                */
                return (values);
            }
            else
            {
                Console.WriteLine("No data found.");
                return null;
            }
        }

        public static void AddRow(string sheet, string ultima_coluna, dynamic ob_lista)
        {
            // Especificando o range das colunas para leitura 
            //var range = $"{sheet}!A:{ultima_coluna}";
            var valueRange = new ValueRange();

            //var oblist = new List<object>() { "BELA", "É", "MUITO", "BONITA", "MEU DEUS" }
            

            Console.WriteLine("1 --> "+ob_lista);
            Console.WriteLine("2 --> " + ob_lista.GetType());
            Console.WriteLine("3 --> " + ob_lista.ToString());
            Console.WriteLine("4 --> " + ob_lista[0]);

            foreach (var coisa in ob_lista)
            {
                var range = $"{coisa["Tabela"]}!A:{colunas_paginas[coisa["Tabela"].ToString()]}";
                
                

                valueRange.Values = new List<IList<object>> { coisa.Values };

                Console.WriteLine(coisa["Tabela"]+" "+valueRange.Values.Count);

                coisa.Remove("Tabela");

                var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
                appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                var appendReponse = appendRequest.Execute();

                //valueRange.Values.Clear();
            }
            //Console.WriteLine("5 --> " + ob_lista[0]["Tabela"]);

            /*
            // Append the above record
            var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = appendRequest.Execute();
            */
        }
    }
}
