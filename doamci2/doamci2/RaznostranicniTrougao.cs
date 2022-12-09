using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doamci2
{
    internal class RaznostranicniTrougao
    {
        private double stranicaA;
        private double stranicaB;
        private double stranicaC;
        private double visinaA;
        
        public RaznostranicniTrougao(double aa, double bb, double cc, double hh) {
            stranicaA = aa;
            stranicaB = bb;
            stranicaC = cc;
            visinaA = hh;
        }

        public double StranicaA
        {
            get { return stranicaA; }
            set 
            { 
                stranicaA = value;
                if(stranicaA < 0) {
                stranicaA = 0;
                }
            }
        }

        public double StranicaB
        { get { return stranicaB; }
        set
            {
                stranicaB = value;
                if(stranicaB < 0)
                {
                    stranicaB = 0;
                }
            }
        }
        public double StranicaC
        {
            get { return stranicaC; }
            set
            {
                stranicaC = value;
                if(stranicaC< 0)
                {
                  stranicaC= 0;
                }
            }
        }

        public double VisinaA
        {
            get { return visinaA; }
            set
            {
                visinaA = value;
                if(visinaA < 0)
                {
                    visinaA = 0;
                }
            }
        }

        public virtual double Obim()
        {
            return stranicaA + stranicaB + stranicaC;
        }
        public virtual double Povrsina()
        {
            if ((stranicaA == stranicaB) && (stranicaB  == stranicaC))
            {
                return stranicaA * Math.Sqrt(3) / 4;
            }
            else { return stranicaA * visinaA / 2; }

        }
    }
}
