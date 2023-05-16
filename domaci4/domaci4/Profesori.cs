using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci4
{
    internal class Profesori
    {
        private string ime;
        private string prezime;
        private string zvanje;
        private string katedra;

        public Profesori() { }

        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if (ime == "")
                {
                    throw new Exception("Morate uneti ime profesora!!!");
                }
            }
        }
        public string Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value;
                if (prezime == "")
                {
                    throw new Exception("Morate uneti prezime profesora!!!");
                }
            }
        }
        public string Zvanje
        {
            get { return zvanje; }
            set
            {
                zvanje = value;
                if (zvanje == "")
                {
                    throw new Exception("Morate uneti zvanje za profesora!!!");
                }
            }
        }
        public string Katedra
        {
            get { return katedra; }
            set
            {
                katedra = value;
                if (katedra == "")
                {
                    throw new Exception("Morate uneti zvanje za profesora!!!");
                }
            }
        }
    }
}

