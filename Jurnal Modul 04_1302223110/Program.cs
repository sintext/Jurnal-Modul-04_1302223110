using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_04_1302223110
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Kodebuah kodebuah = new Kodebuah();

            Console.WriteLine(kodebuah.getKodeBuah(Kodebuah.daftarBuah.Ceri));
            Console.WriteLine(kodebuah.getKodeBuah(Kodebuah.daftarBuah.Apel));
            Console.WriteLine(kodebuah.getKodeBuah(Kodebuah.daftarBuah.Melon));
            Console.WriteLine(" ");

            PosisiKarakterGame game = new PosisiKarakterGame();
            game.Game();
        }
    }
}
