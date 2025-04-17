using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra___programowanie_wizualne_5
{
    public class Settings
    {

        public int columns { get; set; }
        public int rows { get; set; }
        public int time { get; set; }
        public int LiczbaDydelfow { get; set; }
        public int LiczbaSzopow { get; set; }
        public int LiczbaKrokodyli { get; set; }

        public Settings(int kolumny, int wiersze, int czas, int dydelfy, int szopy, int krokodyle)
        {
            columns = kolumny;
            rows = wiersze;
            time = czas;
            LiczbaDydelfow= dydelfy;
            LiczbaSzopow = szopy;
            LiczbaKrokodyli = krokodyle;
        }

        public override string ToString()
        {
            return $"Plansza: {columns}x{rows}, Czas: {time}s, Dydelfy: {LiczbaDydelfow}, Szopy: {LiczbaSzopow}, Krokodyle: {LiczbaKrokodyli}";
        }
    }

}

