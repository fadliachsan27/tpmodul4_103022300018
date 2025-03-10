using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300018
{
    class KodePos
    {
        private static readonly Dictionary<string, string> kodePosTable = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"A. Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

        public static string GetKodePos(string kelurahan)
        {
            if (kodePosTable.TryGetValue(kelurahan, out string kodePos))
            {
                return kodePos;
            }
            else
            {
                return "Kode pos tidak ditemukan";
            }
        }
    }
}
