using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace projeto_integrado.Classes
{
    internal class json_funcs
    {
        static List<object> memb_col = new List<object>() { "IdMembro", "Matricula", "Nome", "DataNasc", "CPF", "RG", "Celular", "Email", "Filiacao", "EnderResidencial", "Profissao", "EnderComercial", "EstadoCivil", "Conjuge", "LocInclusao", "DataInclusao", "Sexo", "Status", "Coordenadora", "DataSaida", "AssMembro", "AssCoordSocial", "AssCoordAdm", "AssCoordFinanceira", "FotoMembro" };
        static List<object> dep_col = new List<object>() { "IdMembro", "NomeMembro", "IdDependente", "Nome", "FotoDependente", "Sexo", "DataNasc", "Parentesco" };
        static List<object> listaPag_col = new List<object>() { "IdMembro", "Nome", "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        static List<object> patrim_col = new List<object>() { "IdPatrimonio", "NumeroPat", "NumeroSerie", "NotaFiscal", "DataCompra", "FimGarantia", "ValorBem", "EstadoConservacao", "ValorAtual", "IdPatrimonioSetor", "IdPatrimonioProduto", "IdMembroResponsavel", "IdPatrimonioFornecedor", "Observacao", "Status", "OrdemCompra" };
        static List<object> patriFabr_col = new List<object>() { "IdPatrimonioFabricante", "NomeFabricante", "Ativo" };
        static List<object> patriGrBens_col = new List<object>() { "IdPatrimonioGrupoBens", "NomeGrupoBens", "IdentificadorGrupoBens", "Ativo" };
        static List<object> patriProd_col = new List<object>() { "IdPatrimonioProduto", "DescriçãoDetalhada", "DepreciacaoAnual", "IdPatrimonioGrupo", "DescricaoResumida", "CodigoProduto", "IdPatrimonioFabricante", "Modelo", "VidaUtilAnos", "Ativo" };
        static List<object> patriSet_col = new List<object>() { "IdPatrimonioSetor", "NomeSetor", "Ativo" };
        static List<object> patriForn_col = new List<object>() { "IdPatrimonioFornecedor", "NomeFornecedor", "CNPJ", "Ativo" };

        public static void Convert_to_json(List<string> dados, string nome_tabela, string ultima_coluna)
        {
            /*
            Converte os dados recebidos para o arq json. Já que os dados veem direto dos inputs, é necessário 
            um parametro nome_tabela para, ao inserir no arq json junto com os novos registros, mais tarde conseguir
            identificar de qual tabela/página é cada registro.
            Em que o arq_path é o caminho onde o meu arquivo json está guardado
            jsonData lê todos os dados do meu arquivo
            dados_salvos des-serializa o arquivo jsonData e guarda em uma lista
            dict_dados é um dicionário criado para conter os dados de inputs em suas respectivas colunas
            */

            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE02.json";
            
            var jsonData = System.IO.File.ReadAllText(arq_path);
            
            var dados_salvos = JsonConvert.DeserializeObject<List<object>>(jsonData);

            Dictionary<string, string> dict_dados = new Dictionary<string, string>();

            // retornando o nome das colunas da tabela específica
            var values_colunas = ColumnName(nome_tabela);
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

            conexao_internet.Run000();

        }

        public static void Update_Convert_to_json(List<string> dados)
        {
            /*
            Mesmo raciocínio da função acima, mas o arq json é zerado. 
            Como todos os registros, já modificados com a nova edição, estão sendo recebidos pelo
            parâmetro dados, é sinserindo todos novamente
             */
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE02.json";
            
            System.IO.File.WriteAllText(arq_path, "");
            List<object> teste = new List<object>();
            Dictionary<string, string> dict_dados = new Dictionary<string, string>();

            foreach (var chave in dados)
            {
                dict_dados = JsonConvert.DeserializeObject<Dictionary<string, string>>(chave);
                teste.Add(dict_dados);
                var json_arq = JsonConvert.SerializeObject(teste);
                System.IO.File.WriteAllText(arq_path, json_arq);
            }

            conexao_internet.Run000();
        }


        public static List<string> UpdateValueJson(string nome_tabela, string nome_chave, string valor, List<string> dados)
        {
            /*
             Função usada para retornar uma nova lista de arquivo json, já atualizada com a nova mudança.
            */
            var arq_json = Read_from_json();
            List<string> valores = new List<string>();
            List<string> chaves = new List<string>();
            
            foreach (var coisa in arq_json)
            {
                if (coisa.GetValue("Tabela").ToString() == nome_tabela && coisa.GetValue(nome_chave).ToString() == valor)
                {
                    JObject jsonObj = JObject.Parse(coisa.ToString());
                    Dictionary<string, string> dictObj = jsonObj.ToObject<Dictionary<string, string>>();

                    dictObj.Remove("Tabela");
                    
                    foreach (var chave in dictObj.Keys)
                    {
                        chaves.Add(chave);
                    }
                    for (int i = 1; i < dictObj.Count; i++)
                    {
                        coisa[chaves[i]] = dados[i];
                    }
                }
                valores.Add(coisa.ToString());
            }

            return valores;
        }

        public static List<string> DeleteValueJson(string nome_tabela, string nome_chave, string valor)
        {
            /*
             Função usada para retornar uma nova lista de arquivo json, já atualizada com a nova mudança (registro deletado).
            */
            var arq_json = Read_from_json();
            List<string> valores = new List<string>();

            foreach (var coisa in arq_json)
            {
                if (coisa.GetValue("Tabela").ToString() == nome_tabela 
                    && coisa.GetValue(nome_chave).ToString() == valor)
                {
                    Console.WriteLine("olha auqi essa linha na func json_func");
                }
                else
                {
                    valores.Add(coisa.ToString());
                }
            }
            return valores;
        }

        public static DataTable Read_from_json_datagridview() 
        {
            /*
            Função de auxílio usada para retornar o arq json em formato de DataTable, para os datagridview 
            */
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE02.json";  // pegar caminho automatico!
            List<string> dict_dados_leitura = new List<string>();

            dynamic jsonArq = JsonConvert.DeserializeObject(File.ReadAllText(arq_path), (typeof(DataTable)));

            return jsonArq;
        }

        public static dynamic Read_from_json()
        {
            /*
             Função que retorna o arq json lido, procurando ele por seu path e des-serializando o mesmo, o retornando em
            dynamic para melhor acesso como objeto json
             */
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE02.json";  // pegar caminho automatico!
            List<string> dict_dados_leitura = new List<string>();

            dynamic jsonArq = JsonConvert.DeserializeObject(File.ReadAllText(arq_path));

            return jsonArq;


        }

        public static List<string> ReadTableRowValue(string nome_tabela, string nome_chave)
        {
            /*
             Função que recebe o nome da tabela e o nome da chave (coluna) que deseja ser pego todos os valores
             No caso, pode ser usada para, do arquivo json, conseguir pegar os dados de uma chave específica.
            */
            var arq_json = Read_from_json();
            List<string> valores = new List<string>();

            foreach (var coisa in arq_json)
            {
                if (coisa.GetValue("Tabela").ToString() == nome_tabela)
                {
                    valores.Add(coisa.GetValue(nome_chave).ToString());
                }
            }

            return valores;
        }

        public static IList<IList<object>> ColumnName(string nome_tabela)
        {
            /*
             Retorna o nome de cada coluna existente na planilha.
            Função utilizada para a inserção dos dados no arq json, podendo identificar cada dado em sua coluna.
             */
            switch (nome_tabela)
            {
                case "Membro":
                    IList<IList<object>> case01 = new List<IList<object>>();
                    case01.Add(memb_col);
                    return case01;

                case "Dependente":
                    IList<IList<object>> case02 = new List<IList<object>>();
                    case02.Add(dep_col);
                    return case02;

                case "ListaPagamento":
                    IList<IList<object>> case03 = new List<IList<object>>();
                    case03.Add(listaPag_col);
                    return case03;

                case "Patrimonio":
                    IList<IList<object>> case04 = new List<IList<object>>();
                    case04.Add(patrim_col);
                    return case04;

                case "PatrimonioFabricante":
                    IList<IList<object>> case05 = new List<IList<object>>();
                    case05.Add(patriFabr_col);
                    return case05;

                case "PatrimonioGrupoBens":
                    IList<IList<object>> case06 = new List<IList<object>>();
                    case06.Add(patriGrBens_col);
                    return case06;

                case "PatrimonioProduto":
                    IList<IList<object>> case07 = new List<IList<object>>();
                    case07.Add(patriProd_col);
                    return case07;

                case "PatrimonioSetor":
                    IList<IList<object>> case08 = new List<IList<object>>();
                    case08.Add(patriSet_col);
                    return case08;

                case "PatrimonioFornecedor":
                    IList<IList<object>> case09 = new List<IList<object>>();
                    case09.Add(patriForn_col);
                    return case09;

                default:
                    return null;
            }
        }

        public static int Read_table( string table_name, string id_)
        {
            /*
             Função que retorna o arq json lido, procurando ele por seu path e des-serializando o mesmo, o retornando em
            dynamic para melhor acesso como objeto json
             */
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE02.json";  // pegar caminho automatico!
            List<string> dict_dados_leitura = new List<string>();

            dynamic jsonArq = JsonConvert.DeserializeObject(File.ReadAllText(arq_path));
            List<string> teste = new List<string>();

            //JObject jsonObj = JObject.Parse(jsonArq.ToString());
            //Dictionary<string, string> dictObj = jsonObj.ToObject<Dictionary<string, string>>();

            foreach (var coisa in jsonArq)
            {
                
                if (coisa["Tabela"] == table_name)
                {
                    Console.WriteLine(coisa["Tabela"]);
                    Console.WriteLine("--------");
                    teste.Add(coisa.ToString());
                }
            }
            //Console.WriteLine("dict teste = " + dictObj);
            Console.WriteLine("string teste = " + teste.Count);

            JObject jsonObj = JObject.Parse(teste[teste.Count-1]);
            Dictionary<string, string> dictObj = jsonObj.ToObject<Dictionary<string, string>>();
            Console.WriteLine(dictObj[id_]);


            return int.Parse(dictObj[id_])+1;


        }
    }
}
