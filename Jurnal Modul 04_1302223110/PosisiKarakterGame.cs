using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Modul_04_1302223110
{
    internal class PosisiKarakterGame
    {
        enum State {Tengkurap, Jongkok, Berdiri, Terbang};
        
        public void Game()
        {
            String Perintah = " ";
            State state = State.Berdiri;
            String[] posisi = { "BERDIRI", "JONGKOK", "BERDIRI", "TERBANG" };
            while (Perintah != "exit")
            {
                Console.WriteLine(posisi[(int) state] + " ,POSISI KARAKTER GAME");
                Console.Write("Masukkan Perintah: ");
                Perintah = Console.ReadLine();

                switch (state)
                {
                    case State.Tengkurap:
                        if (Perintah == "W")
                        {
                            state = State.Jongkok;

                        } else
                        {
                            state = State.Tengkurap;
                        };
                        break;
                    case State.Jongkok:
                        if (Perintah == "W")
                        {
                            state = State.Berdiri;

                        } else if (Perintah == "S")
                        {
                            state = State.Tengkurap;

                        }
                        else
                        {
                            state = State.Jongkok;
                        };
                        break;
                    case State.Berdiri:
                        if(Perintah == "W")
                        {
                            state = State.Terbang;

                        } else if (Perintah == "S")
                        {
                            state = State.Jongkok;

                        }  else
                        {
                            state = State.Berdiri;
                        };
                        break;
                    case State.Terbang:
                        if (Perintah == "S")
                        {
                            state = State.Berdiri;
                        } else if(Perintah == "X")
                        {
                            state = State.Jongkok;
                        } else
                        {
                            state = State.Terbang;
                        };
                        break;

                }
            }
            if (Perintah == "W")
            {
                Console.WriteLine("tombol arah atas ditekan");
            }
            if (Perintah == "S")
            {
                Console.WriteLine("tombol arah bawah ditekan");
            }


        }
    }
}
