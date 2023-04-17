﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
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
        //static readonly string sheet = "Membro";
        static readonly string SpreadsheetId = "1OYojwhnlzXB0kaJNVM1dsZrUUlRdlpS2OSzuVassbN0";
        static SheetsService service;

        /*
        static void Main()
        {
            Init();
        }
        */

        public static void Init()
        {
            GoogleCredential credential;

            //Reading Credentials File...
            using (var stream = new FileStream("chave_coisa_servico.json", FileMode.Open, FileAccess.Read)) // ou chvae_coisa_servico
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Creating Google Sheets API service...
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        static void ReadSheet(string sheet) // STRING OU static readonly string??
        {

            // Specifying Column Range for reading...
            var range = $"{sheet}!A:E";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            // Ecexuting Read Operation...
            var response = request.Execute();

            // Getting all records from Column A to E...
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

        public static void AddRow(string sheet, List<object> ob_lista)
        {
            // Especificando o range das colunas para leitura 
            var range = $"{sheet}!A:E";
            var valueRange = new ValueRange();
            // Data for another Student...
            //var oblist = new List<object>() { "BELA", "É", "MUITO", "BONITA", "MEU DEUS" };
            var oblist = ob_lista;
            valueRange.Values = new List<IList<object>> { oblist };
            // Append the above record...
            var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = appendRequest.Execute();
        }

        static void Convert_to_json()
        {

        }
    }
}
