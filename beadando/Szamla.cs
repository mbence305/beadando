namespace beadando
{
    /// <summary>
    /// Számla adatait leíró osztály
    /// </summary>
    internal class Szamla
    {
        public int ID { get; set; }
        public string tulaj_nev { get; set; }
        public int egyenleg { get; set; }

        public Szamla(int id, string nev, int egyenleg) {
            this.ID = id;
            this.tulaj_nev = nev;
            this.egyenleg = egyenleg;
        }

        public bool Levon(int szam) {
            if (this.egyenleg>=szam) {
                this.egyenleg -= szam;
                return true;
            }
            else {
                return false;
            }
            
        }

        public void Felrak(int szam)
        {
            this.egyenleg += szam;
        }

        public void Valtas(string nev) {
            this.tulaj_nev = nev;
        }

        public bool Utalas(int osszeg, Szamla delikvens) {
            if (this.egyenleg >= osszeg)
            {
                this.Levon(osszeg);
                delikvens.Felrak(osszeg);
                return true;
            }
            else {
                return false;
            }
        }
    }
}