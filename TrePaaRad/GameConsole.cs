namespace TrePaaRad;

public class GameConsole
{
    private readonly Board _board;

    public GameConsole(Board board)
    {
        _board = board;
    }
    
//     public void Show(Board board)
//     {
//         Console.WriteLine($@" 
//  
//       a b c
//      ┌─────┐
//     1│{_board.Squares[0].SquareContent} {_board.Squares[1].SquareContent} {_board.Squares[2].SquareContent}│
//     2│{_board.Squares[3].SquareContent} {_board.Squares[4].SquareContent} {_board.Squares[5].SquareContent}│
//     3│{_board.Squares[6].SquareContent} {_board.Squares[7].SquareContent} {_board.Squares[8].SquareContent}│
//      └─────┘
//
// ");

    public void Show()
    {
        Console.Clear();
        Console.WriteLine(@$"  a b c
 ┌─────┐
1│{GetChar(0)} {GetChar(1)} {GetChar(2)}│
2│{GetChar(3)} {GetChar(4)} {GetChar(5)}│
3│{GetChar(6)} {GetChar(7)} {GetChar(8)}│
 └─────┘");
    }

    private string GetChar(int index)
    {
        var square = _board.Squares[index];
        return square.IsEmpty() ? " " : 
            square.IsPlayer1() ? "x" : "o";
    }

    
}