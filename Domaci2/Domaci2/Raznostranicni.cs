using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci2
{
    class Raznostranicni
    {
        private double stranicaA;
        private double stranicaB;
        private double stranicaC;

        public Raznostranicni(double aa, double bb, double cc)
        {
            stranicaA = aa;
            stranicaB = bb;
            stranicaC = cc;
        }
        
        public double StranicaA
        {
            get { return stranicaA; } 
            set 
            {
                stranicaA = value;
                if (stranicaA < 0)
                {
                    stranicaA = 0;
                }
            }
        }

        public double StranicaB
        {
            get { return stranicaB; }
            set
            {
                stranicaB = value;
                if (stranicaB < 0)
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
                if (stranicaC < 0)
                {
                    stranicaC = 0;
                }
            }
        }

        public virtual double Obim()
        {
            return stranicaA + stranicaB + stranicaC;
        }

        public virtual double Povrsina()
        {
            return 0.25 * Math.Sqrt((4 * Math.Pow(stranicaA, 2) * Math.Pow(stranicaB, 2)) - Math.Pow((Math.Pow(stranicaA, 2) + Math.Pow(stranicaB, 2) - Math.Pow(stranicaC, 2)),2));
        }
    }
}
