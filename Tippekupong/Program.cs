

using Tippekupong;

var kamp1 = new Match("Arsenal", "Liverpool");


kamp1.BetOnMatch();

kamp1.StartMatch();
while (kamp1.GetMatchStatus())
{
    Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\n Angi kommando: ");
    kamp1.UpdateGoalOrEndMatch(Console.ReadLine());
}

Console.WriteLine(kamp1.GetBettingResult());
