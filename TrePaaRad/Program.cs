

using TrePaaRad;

var boardModel = new Board();
var gameConsole = new GameConsole(boardModel);
while (true)
{
    gameConsole.Show();
    Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
    var position = Console.ReadLine();
    boardModel.Mark(position);
}
