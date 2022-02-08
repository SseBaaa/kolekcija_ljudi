using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija_Ljudi
{
    internal class Ljudi
    {
        private string ime, prezime, rod, dodatak;
        private int godRod;


        public override string ToString()
        {
            string ispis = this.ime + "\t" + this.prezime + "\t" + this.godRod + "\t" + this.rod + "\t" + this.dodatak;
            return ispis;
        }
        public Ljudi(string ime, string prezime, int godRod, string rod, string dodatak)
        {
            this.Ime = ime; 
            this.Prezime = prezime;
            this.Rod = rod;
            this.GodRod = godRod; 
            this.Dodatak = dodatak;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Rod { get => rod; set => rod = value; }
        public int GodRod { get => godRod; set => godRod = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }

    }
}
