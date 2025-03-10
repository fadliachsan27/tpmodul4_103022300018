using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300018
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci; // State awal
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                Console.WriteLine("Tidak bisa membuka pintu karena masih terkunci.");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka.");
            }
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci.");
            }
        }

        public void ToggleLock()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}
