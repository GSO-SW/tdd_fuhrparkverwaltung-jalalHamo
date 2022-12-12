using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private double kilometerstand;
        private double tankinhalt;
        private double verbrauchProHundertKilometer;

        public Auto (double kilometerstand, double tankinhalt, double verbrauchProSekunde) : this (kilometerstand)
        {
            this.tankinhalt = tankinhalt;
            this.verbrauchProHundertKilometer = verbrauchProSekunde;
        }

        public Auto(double kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public void Fahren (double streckeInKilmeter)
        {
            if(streckeInKilmeter >= 0)
            {
                if(this.tankinhalt >= (verbrauchProHundertKilometer / 100) * streckeInKilmeter)
                {
                    this.tankinhalt -= (verbrauchProHundertKilometer / 100) * streckeInKilmeter;
                    this.kilometerstand += streckeInKilmeter;
                }
                else
                {
                    this.kilometerstand += (this.tankinhalt * 100) / this.verbrauchProHundertKilometer;
                    this.tankinhalt = 0;
                }
            }
        }

        public double Kilometerstand
        {
            get { return this.kilometerstand; } 
        }

        public double Tankinhalt
        {
            get { return this.tankinhalt; }
        }

        public double VerbrauchProHundertKilometer
        {
            get { return this.verbrauchProHundertKilometer; }
        }
    }
}
