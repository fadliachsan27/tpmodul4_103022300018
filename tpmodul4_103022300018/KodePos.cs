using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300018
{
    public class KodePos
    {
        private Dictionary<string, string> daftarKodePos;

        public KodePos()
        {
            // Menginisialisasi tabel kode pos dengan teknik table-driven
            daftarKodePos = new Dictionary<string, string>
        {
            { "Batununggal", "40266" },
            { "A. Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" },
            { "Samoja", "40273" }
        };
        }

        public string GetKodePos(string kelurahan)
        {
            if (daftarKodePos.ContainsKey(kelurahan))
            {
                return daftarKodePos[kelurahan];
            }
            else
            {
                return "Kode Pos tidak ditemukan";
            }
        }

        public void TampilkanSemuaKodePos()
        {
            Console.WriteLine("Daftar Kode Pos:");
            foreach (var entry in daftarKodePos)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
