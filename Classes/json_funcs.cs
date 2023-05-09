using Google.Apis.Sheets.v4;
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
        static List<object> listaPag_col = new List<object>() { "IdMembro", "Nome", "Pagamento", "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        static List<object> patrim_col = new List<object>() { "IdPatrimonio", "NumeroPat", "NumeroSerie", "NotaFiscal", "DataCompra", "FimGarantia", "ValorBem", "EstadoConservacao", "ValorAtual", "IdPatrimonioSetor", "IdPatrimonioProduto", "IdMembroResponsavel", "IdPatrimonioFornecedor", "Observacao", "Status", "OrdemCompra" };
        static List<object> patriFabr_col = new List<object>() { "IdPatrimonioFabricante", "NomeFabricante", "Ativo" };
        static List<object> patriGrBens_col = new List<object>() { "IdPatrimonioGrupoBens", "NomeGrupoBens", "IdentificadorGrupoBens", "Ativo" };
        static List<object> patriProd_col = new List<object>() { "IdPatrimonioProduto", "DescriçãoDetalhada", "DepreciacaoAnual", "IdPatrimonioGrupo", "DescricaoResumida", "CodigoProduto", "IdPatrimonioFabricante", "Modelo", "VidaUtilAnos", "Ativo" };
        static List<object> patriSet_col = new List<object>() { "IdPatrimonioSetor", "NomeSetor", "Ativo" };
        static List<object> patriForn_col = new List<object>() { "IdPatrimonioFornecedor", "NomeFornecedor", "CNPJ", "Ativo" };

        public static void Convert_to_json(List<string> dados, string nome_tabela, string ultima_coluna)
        {
            // path do arquivo json, onde será guardado as informações
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE02.json";
            // ler todos os dados que o arq contém
            var jsonData = System.IO.File.ReadAllText(arq_path);
            // des-serializar o arquivo e guardar em uma lista
            var dados_salvos = JsonConvert.DeserializeObject<List<object>>(jsonData);

            // dicionário para conter os dados recebidos dos inputs em suas respectivas colunas
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

        }

        public static DataTable Read_from_json_datagridview()  // lendo do arq json criado
        {
            string arq_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\JSONTESTE02.json";  // pegar caminho automatico!
            List<string> dict_dados_leitura = new List<string>();

            dynamic jsonArq = JsonConvert.DeserializeObject(File.ReadAllText(arq_path), (typeof(DataTable)));

            return jsonArq;
        }

        public static dynamic Read_from_json()  // lendo do arq json criado
        {
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

        public static void UpdateValueJson(string nome_tabela, string nome_chave, string valor, List<string> dados)
        {
            /*
             Função que recebe o nome da tabela, o nome da chave (coluna) e o nome do valor que deseja ser pego todos os valores
             No caso, por exemplo, quero a linha que contém o "Nome" "Fulano" na tabela "Membro".
            */
            var arq_json = Read_from_json();
            List<string> valores = new List<string>();
            List<string> chaves = new List<string>();

            foreach (var coisa in arq_json)
            {
                if (coisa.GetValue("Tabela").ToString() == nome_tabela && coisa.GetValue("CPF").ToString() == valor)
                {
                    JObject jsonObj = JObject.Parse(coisa.ToString());
                    Dictionary<string, string> dictObj = jsonObj.ToObject<Dictionary<string, string>>();

                    dictObj.Remove("Tabela");

                    foreach (var chave in dictObj.Keys)
                    {
                        Console.WriteLine("chave" + chave);
                        chaves.Add(chave);
                        
                    }
                    for(int i = 0; i < dictObj.Count; i++)
                    {
                        Console.WriteLine("chaves[i] " + chaves[i] + "| dados[i] " + dados[i]);
                        //Console.WriteLine("dados[i]" + dados[i]);
                        //Console.WriteLine("chaves[i]" + chaves[i]);
                        //arq_json[chaves[i]] = dados[i];
                    }
                    //Console.WriteLine("Nome que eu quero --> " + coisa.GetValue("Nome").ToString());
                }
            }

            //return valores;
        }
        // ReadTableColumnName
        public static IList<IList<object>> ColumnName(string nome_tabela)
        {
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
            //var teste = timer_refresh.refreshReg()
        }
    }
}
