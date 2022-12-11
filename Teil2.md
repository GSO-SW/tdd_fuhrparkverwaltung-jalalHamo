## Testfallbeschreibungen
Entwerfen Sie Tests für die folgenden Beschreibungen und implementieren Sie geeignete Lösungen! Gehen Sie testgetrieben vor: jeweils einen Testfall, dann die Lösung dazu.

1.	Implementieren Sie erst eine Lösung für Fahren_SteigertKilometerstand!

2.	Eine Fahrt mit negativen Kilometern soll keine Auswirkung auf den Kilometerstand haben.
Beispiel: Wenn ein Auto einen Kilometerstand von 10km hat und eine Fahrt aus Versehen mit -1 Kilometer eingegeben wird, dann soll der Kilometerstand nicht verändert werden.

3.	Jedes Auto hat einen Tankinhalt und einen Verbrauch pro 100km. Bei einer Fahrt soll der Tankinhalt entsprechend des Verbrauchs sinken. 
Beispiel: Bei einem Tankinhalt von 10l und einem Verbrauch von 5,7l pro 100km, sollten nach einer Fahrt von 100km noch 4,3l im Tank vorhanden sein.

4.	Eine zu lange Fahrt darf den Tankinhalt nicht negativ werden lassen.
Beispiel: Bei einem Tankinhalt von 10l und einem Verbrauch von 5,7l pro 100km, sollten nach einer Fahrt von 200km 0l im Tank vorhanden sein.

5.	Eine zu lange Fahrt soll den Kilometerstand nur so weit steigern, wie das Auto auch tatsächlich fahren kann. 
Beispiel: Bei einem Tankinhalt von 10l und einem Verbrauch von 5,7l pro 100km, kann ein Auto keine 200km weit fahren. Der Kilometerstand darf daher nicht um 200km gesteigert werden, sondern nur um 175km.

