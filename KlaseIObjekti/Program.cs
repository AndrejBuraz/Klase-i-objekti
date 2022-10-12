using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instanciranje objekta
            Osoba osoba = new Osoba();
            osoba.SetIme("Pero");
            osoba.SetPrezime("Perić");
            osoba.SetGodRodjenja(2005);
            osoba.SetVisina(180);
            osoba.SetTezina(75);
            osoba.SetSpol('M');

            Console.WriteLine("Osoba 1:");

            Console.WriteLine("Ime i prezime: " + osoba.GetIme() + " " + osoba.GetPrezime() + ", godina rođenja: " + osoba.GetGodRodjenja() + ", visina: " + 
                osoba.GetVisina() + ", tezina: " + osoba.GetTezina() + ", spol: " + osoba.GetSpol());

            //objekt 2
            Osoba osoba2 = new Osoba("Ana", "Anić", 2021, 178, 56, 'Ž');
            Console.WriteLine("Osoba 2:");
            Console.WriteLine(osoba2.Ispis());

            Console.WriteLine("\r\nOsoba 2 - override");
            Console.WriteLine(osoba2.ToString());


            Console.ReadKey();
        }
    }
    class Osoba
    {
        //svojstva
        string ime, prezime;
        int godRodjena, visina, tezina;
        char spol;

        //metode

        //setteri - sluze za postavljanje vrijednosti svojstava
        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        public void SetPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void SetGodRodjenja(int godRodjenja)
        {
            this.godRodjena = godRodjenja;
        }
        public void SetVisina(int visina)
        {
            this.visina = visina;
        }
        public void SetTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void SetSpol(char spol)
        { 
            this.spol = spol;
        }


        //getteri - sluze za citanje vrijednosti svojstava
        public string GetIme()
        {
            return this.ime;
        }
        public string GetPrezime()
        {
            return this.prezime;
        }
        public int GetGodRodjenja()
        {
            return this.godRodjena;
        }
        public int GetVisina()
        {
            return this.visina;
        }
        public int GetTezina()
        {
            return this.tezina;
        }
        public char GetSpol()
        {
            return this.spol;
        }

        //metode za ispi

        public string Ispis()
        {
            string ispis = ("Ime i prezime: " + this.GetIme() + " " + this.GetPrezime() + ", godina rođenja: " + this.GetGodRodjenja() + ", visina: " +
                this.GetVisina() + ", tezina: " + this.GetTezina() + ", spol: " + this.GetSpol());
            return ispis;
        }
        public override string ToString()
        {
            string ispis = ("Ime i prezime: " + this.GetIme() + " " + this.GetPrezime() + ", godina rođenja: " + this.GetGodRodjenja() + ", visina: " +
               this.GetVisina() + ", tezina: " + this.GetTezina() + ", spol: " + this.GetSpol());
            return ispis;
        }

        //konstruktori
        public Osoba()
        {

        }
        public Osoba(string ime, string prezime, int godRodjenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodjena = godRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;
        }

        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
