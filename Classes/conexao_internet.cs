using System;
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


        public static void Run000()  // TAVA INTERNAL AO INVES DE PUBLIC
        {
            int seconds = 5 * 1000;

            var timer = new System.Threading.Timer(checarInternetFunc, null, 0, seconds);

            //Console.ReadKey();
        }

        static void checarInternetFunc(object o)
        {
            int descric;
            Console.WriteLine(InternetGetConnectedState(out descric, 0).ToString());
        }

        public static void TimerMethod(object o)
        {
            Console.WriteLine("aaaaaaaa -> " + DateTime.Now);
        }
    }
}
