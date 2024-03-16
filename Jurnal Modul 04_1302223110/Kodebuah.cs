using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_04_1302223110
{
    internal class Kodebuah
    {
        public String getKodeBuah(String buah)
        {
            String[] arBuah = {"A00", "B00", "C00", "D00", "E00", "F00",
                "H00", "I00", "J00", "K00", "l00", "M00", "N00", "O00"};
            { 
                int index = (int)daftarBuah;
                return Kodebuah[index];
            }
        }
    }

    public enum daftarBuah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    }
}
