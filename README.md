# Sublime_Case_FW
__Frederick Wennborg__

Arbetsprocess:
- 30min – Läste igenom arbetsbeskrivning och API-Dokumentationen. Gjorde anrop till API via postman för att bekanta mig med svaren samt hitta rätt end points utifrån arbetsbeskrivningen.

- 1h:30min – Startade ett MVC .NET projekt och anslöt till ett nytt git repository. Skapade API Service klassbibliotek och laddade ner JSON nuget. Skapade DTO klasser i API library med matchande properties som API:ets nyckelvärden. Skapade GetAllPrograms metod som anropar API:et och konverterar data till ett nytt ProgramResponse objekt.
Kopplade ihop MVC-projekt med APIService via dependency injection och hämtade in ProgramResponse till index i HomeController som jag sedan förde vidare in till View. Skapade en enkel lista där jag skrev ut Model.Program värdena. 

- 2h:30min -  Satt med postman för att ta reda på korrekt podfiles end points. Skapade GetAllPodfilesByProgramID metod som tar emot id och skickar ut alla avsnitt per program. Planerade kodstruktur.
- 3h:30min – Överförde DTO-värden till nya models i HomeController med foreach och LINQ. Anpassade lista efter nya värden. Listan skriver ut alla program med tillhörande avsnitt.
- 4h:30min – La till page och size variabler till GetAllPodfiles metoden, som gör det möjligt att välja hur många avsnitt som ska tas med. La även till möjlighet att välja kategori baserat på categoryId som skickas in. La till automapper för att enklare mappa mellan ProgramModel och ProgramDTO. Gjorde styling på index sidan i css.

- 5h 15min: La till audio player för poddavsnitten. Skapade UtilityServiceLibrary med metoder för att konvertera till lokaltid och ändra till passande tidsformat baserat på antal sekunder. Gjorde en till view som innehåller ett valt program med dess samtliga poddavsnitt. La till styling i css. 
