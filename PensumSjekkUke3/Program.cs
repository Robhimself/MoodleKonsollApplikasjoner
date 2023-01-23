using PensumSjekkUke3;

/*  Lag en applikasjon som kan generere opp flere forskjellige virtuelle kjæledyr. 
    
    1. Bruk constructor, skal ikke kunne endre navn, age eller andre characteristics utenfra klassen.
    
    2. Lag funksjonalitet som gjør at man kan gi dyret mat, 
    bruk en overload til å gi en annen feedback til console dersom det er favorittmaten til dyret 
    - feks. "Hurra dette er det beste jeg vet, tusen takk for maten!" istedenfor feks. "Takk for maten".
*/

var hest = new Pet("Harald", 1, "Brun");
Console.WriteLine($"Din nye hest heter: {hest.Name}.");
Console.WriteLine(Pet.Counter);

var katt = new Pet("Fredrik", 2, "Hvit");
Console.WriteLine($"Din nye hest heter: {hest.Name}.");
Console.WriteLine(Pet.Counter);

hest.Feed("Høy", true);

hest.Feed("Brunost");

hest.Feed("x");