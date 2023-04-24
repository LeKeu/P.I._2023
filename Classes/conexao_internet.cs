﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrado.Classes
{
    internal class conexao_internet
    {

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        // AS FUNÇÕES ABAIXO, EM CONJUNTO, FAZEM A CHECAGEM DA CONEXÃO COM INTERNET
        public static void Run000()  // TAVA INTERNAL AO INVES DE PUBLIC
        {
            int seconds = 5 * 1000; // de 5 em 5 segundos

            var timer = new System.Threading.Timer(checarInternetFunc, null, 0, seconds);

            //Console.ReadKey();
        }

        static void checarInternetFunc(object o)
        {
            int descric;
            Console.WriteLine(InternetGetConnectedState(out descric, 0).ToString());

            // abaixo há uma var booleana que recebe, convertendo de string para bool, true ou false
            bool is_connected = Convert.ToBoolean(InternetGetConnectedState(out descric, 0).ToString());
            
            // se for verdadeiro - se houver conexão - ler do arquivo json
            if (is_connected)
            {
                json_funcs.Read_from_json();
            }
        }

        /*
        public static void TimerMethod(object o)
        {
            Console.WriteLine("aaaaaaaa -> " + DateTime.Now);
        }
        */
    }
}
