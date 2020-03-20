using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    class Lakopark

    {
        private string nev;
        private int maxHazSzam;
        private int utcakSzama;
        private int[,] hazak;

        public Lakopark(string nev,  int utcakSzama,int maxHazSzam ,int[,] hazak)
        {
            this.nev = nev;
            this.maxHazSzam = maxHazSzam;
            this.utcakSzama = utcakSzama;
            this.hazak = hazak;
        }

        public int[,] Hazak { get => hazak; set => hazak = value; }
        public int MaxHazSzam { get => maxHazSzam; set => maxHazSzam = value; }
        public string Nev { get => nev; set => nev = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }


    }

}
