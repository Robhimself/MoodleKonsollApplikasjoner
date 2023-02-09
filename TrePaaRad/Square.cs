namespace TrePaaRad;

public class Square
{
    // public string SquareContent = " ";
    //
    //
    // private bool IsEmpty()
    // {
    //     return string.IsNullOrWhiteSpace(SquareContent);
    // }
    //
    // public bool IsTakenByPlayer1()
    // {
    //     return string.Equals(SquareContent, "X");
    // }
    //
    // public void Mark(bool takenByPlayer1)
    // {
    //     if (!IsEmpty()) return;
    //
    //     SquareContent = takenByPlayer1 ? "X" : "O";
    // }
    private int _content;
    public bool IsEmpty()
    {
        return _content == 0;
    }

    public bool IsPlayer1()
    {
        return _content == 1;
    }

    public void Mark(bool isPlayer1)
    {
        if (!IsEmpty()) return;
        _content = isPlayer1 ? 1 : 2;
    }
}