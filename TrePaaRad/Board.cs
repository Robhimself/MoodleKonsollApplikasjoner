namespace TrePaaRad;

public class Board
{
    public Square[] Squares { get; set; }

    public Board()
    {
        Squares = new Square[9];

        for (var i = 0; i < Squares.Length; i++)
        {
            Squares[i] = new Square();
        }
    }
    
    public void Mark(string position)
    {
        var column = position[0];
        var row = position[1];
        var columnIndex = column - 'a';
        var rowIndex = row - '1';
        var index = rowIndex*3 + columnIndex;

        Squares[index].Mark(true);
    }
}