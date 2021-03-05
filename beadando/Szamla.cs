namespace beadando
{
    /// <summary>
    /// Számla adatait leíró osztály
    /// </summary>
    internal class Szamla
    {
        /// <summary>
        /// Példány azonosító.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Számla tulajdonos neve.
        /// </summary>
        public string tulaj_nev { get; set; }

        /// <summary>
        /// Számla egyenlege.
        /// </summary>
        public int egyenleg { get; set; }

        /// <summary>
        /// generál két paraméterből egy teljes nevet.
        /// </summary>
        /// <param name="id"> Számmla azonosító</param>
        /// <param name="nev"> Számla tulajdonos neve</param>
        /// <param name="egyenleg"> Számla egyenleg</param>
        public Szamla(int id, string nev, int egyenleg) {
            this.ID = id;
            this.tulaj_nev = nev;
            this.egyenleg = egyenleg;
        }

        /// <summary>
        /// Levon egy összeget a számla egyenlegről , megnézi hogy van e elég pénz a számlán, ha nincs visszaad egy false értéket.
        /// </summary>
        /// <param name="szam">Levonni kívánt összeg</param>
        /// <return>bool</return>
        public bool Levon(int szam) {
            if (this.egyenleg>=szam) {
                this.egyenleg -= szam;
                return true;
            }
            else {
                return false;
            }
            
        }

        /// <summary>
        /// Hozzáad egy összeget a számla egyenlegéhez.
        /// </summary>
        /// <param name="szam">Feltölteni kívánt összeg</param>
        public void Felrak(int szam)
        {
            this.egyenleg += szam;
        }

        /// <summary>
        /// Megváltoztatja a számla tulajdonos nevét.
        /// </summary>
        /// <param name="nev"> Az új név</param>
        public void Valtas(string nev) {
            this.tulaj_nev = nev;
        }

        /// <summary>
        /// Összeg utalás egyik számláról a másikra, ha ninc elég pénz a számlán akkor visszadob egy false értéket.
        /// </summary>
        /// <param name="osszeg"> Átutalni kívánt összeg</param>
        /// <param name="delikvens"> Cél számla</param>
        /// <return>bool</return>
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