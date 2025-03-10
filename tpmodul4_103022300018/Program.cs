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
            // TEKNIK TABLE-DRIVEN
            KodePos kodePos = new KodePos();

            Console.WriteLine("Menampilkan Semua Kode Pos:");
            string[] kelurahanList = { "Batununggal", "A. Kujangsari", "Mengger", "Wates", "Cijaura",
                                   "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
            foreach (string kelurahan in kelurahanList)
            {
                Console.WriteLine($"{kelurahan}: {kodePos.GetKodePos(kelurahan)}");
            }

            // TEKNIK STATE-BASED
            DoorMachine door = new DoorMachine();
            Console.WriteLine("\nMensimulasikan perubahan state:");
            Console.WriteLine("\n1. Mencoba membuka pintu saat terkunci:");
            door.BukaPintu();
            Console.WriteLine("\n2. Membuka kunci pintu:");
            door.ToggleLock();
            Console.WriteLine("\n3. Mencoba membuka pintu setelah tidak terkunci:");
            door.BukaPintu();
            Console.WriteLine("\n4. Mengunci pintu kembali:");
            door.KunciPintu();
            Console.WriteLine("\n5. Membuka pintu saat terkunci lagi:");
            door.BukaPintu();
        }
    }
}
