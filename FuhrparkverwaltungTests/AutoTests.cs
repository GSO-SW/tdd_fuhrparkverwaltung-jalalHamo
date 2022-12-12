using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;
using Microsoft.VisualBasic;
using System;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        //1
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            double kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            double streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        //2
        [TestMethod]
        public void Fahren_negativeWerteAendernKilometerstandNicht()
        {
            //Arrange
            double kilometerstand = 10;
            Auto b = new Auto(kilometerstand);
            double streckeInKilometern = -1;

            //Act
            b.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(kilometerstand, b.Kilometerstand);
        }

        //3
        [TestMethod]
        public void Fahren_sinktTankinhalt()
        {
            //Arrange
            double kilometerstand = 0;
            double tankinhalt = 10;
            double verbrauchProHundertKilometer = 5.7;
            Auto c = new Auto(kilometerstand, tankinhalt, verbrauchProHundertKilometer);

            double streckeInKilometern = 100;
            double tankinhalt_Soll = 4.3;


            //Act
            c.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(tankinhalt_Soll, c.Tankinhalt);
        }

        //4
        [TestMethod]
        public void Fahren_LangeZeitMachtTankinhaltNichtMinus()
        {
            //Arrange
            double kilometerstand = 0;
            double tankinhalt = 10;
            double verbrauchProHundertKilometer = 5.7;
            Auto d = new Auto(kilometerstand, tankinhalt, verbrauchProHundertKilometer);

            double streckeInKilometern = 200;
            double tankinhalt_Soll = 0;


            //Act
            d.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(tankinhalt_Soll, d.Tankinhalt);
        }

        //5
        [TestMethod]
        public void Fahren_SteigertKilometerstandNurSolangeTankinhaltReicht()
        {
            //Arrange
            double kilometerstand = 0;
            double tankinhalt = 10;
            double verbrauchProHundertKilometer = 5.7;
            Auto e = new Auto(kilometerstand, tankinhalt, verbrauchProHundertKilometer);

            double streckeInKilometern = 200;
            double kilometerstand_Soll = 175;


            //Act
            e.Fahren(streckeInKilometern);
            int kilometerstand_Ist = Convert.ToInt32(e.Kilometerstand);

            //Assert
            Assert.AreEqual(kilometerstand_Soll, kilometerstand_Ist);
        }
    }
}
