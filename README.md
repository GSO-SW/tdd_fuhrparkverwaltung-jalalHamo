# Ü: UnitTests entwerfen und implementieren
Zur Verwaltung eines Fuhrparks soll eine neue Software entworfen werden. Das gewählte Vorgehen arbeitet testgetrieben unter der Verwendung von UnitTests. Ihnen liegt die folgende Beschreibung vor: 

_Für jedes Auto sollen nach einer Fahrt die gefahrenen Kilometer zum Kilometerstand hinzugefügt werden._

Eine Kollegin hat bereits den ersten Unit Test entworfen:
```csharp
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;

namespace TestprojektTests
{
  [TestClass]
  public class TestTests
  {
    //[TestMethod]
    public void Fahren_SteigertKilometerstand()
    {
      //Arrange
      int kilometerstand = 0;
      Auto a = new Auto(kilometerstand);
      int streckeInKilometern = 50;

      //Act
      a.Fahren(streckeInKilometern );

      //Assert
      Assert.AreEqual(50, a.Kilometerstand);
    }
  }
}
```

## Teil 1: Fragen
Beantworten Sie auf Basis der obigen Beschreibung diese Fragen:
1.	Wie heißt das zu testende Projekt?

   Antwort:

2.	Wie heißt die zu testende Klasse?

   Antwort:

3.	Sind die Namenskonventionen eingehalten? Falls nein: Welche Verbesserung schlagen Sie vor?

   Antwort: 

4.	Wie viele Tests würden im Testexplorer angezeigt werden? (Begründen Sie Ihre Antwort!)

   Antwort:

5.	Wie würde, ausgehend von diesem Testfall, ein UML-Klassendiagramm für die zu testende Klasse aussehen? (Gerne dürfen Sie hier eine Tabelle einfügen, z.B. mit dem [MarkdownTableGenerator](https://www.tablesgenerator.com/markdown_tables)

   Antwort:
