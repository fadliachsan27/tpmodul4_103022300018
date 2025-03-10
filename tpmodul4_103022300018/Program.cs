using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();
            string kodePos = KodePos.GetKodePos(kelurahan); // Memanggil method dari KodePos.cs
            Console.WriteLine($"Kode pos untuk {kelurahan}: {kodePos}");
        }
    }
}
