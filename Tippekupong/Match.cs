namespace Tippekupong;

public class Match
{
    
    private bool _isRunning;
    private int _homeGoals = 0;
    private int _awayGoals = 0;
    private string? _currentBet;
    private string? _finalResult;
    private string? _homeTeamName;
    private string? _awayTeamName;

    public Match(string homeTeam, string awayTeam)
    {
        _homeTeamName = homeTeam;
        _awayTeamName = awayTeam;
    }

    public void BetOnMatch()
    {
        Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
        string userBet = Console.ReadLine();
        if (userBet is "H" or "U" or "B" or "HU" or "HB" or "UB" or "HUB")
        {
            _currentBet = userBet;
        }
        else
        {
            Console.WriteLine("Vennligst bruk en gyldig kommando...");
            BetOnMatch();
        }
    }
    
    public void UpdateGoalOrEndMatch(string whoScored)
    {
        if (whoScored == "X")
        {
            EndMatch();
            return;
        }
        if (whoScored == "H") _homeGoals++;
        else if (whoScored == "B") _awayGoals++;
        else
        {
            Console.WriteLine("Du kan kun angi kommando \"H\" for hjemmescoring, \"B\" for bortescoring eller \"X\" for å avslutte kampen.");
            UpdateGoalOrEndMatch(Console.ReadLine());
            return;
        }

        Console.WriteLine($"Stillingen er {_homeTeamName}:{_awayTeamName} {_homeGoals} - {_awayGoals}");
    }

    public bool GetMatchStatus()
    {
        return _isRunning;
    }

    public void StartMatch()
    {
        _isRunning = true;
    }

    private void EndMatch()
    {
        _isRunning = false;

        _finalResult = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
    }

    public string GetBettingResult()
    {
        if (_isRunning) EndMatch();
        
        var isBetCorrect = _currentBet.Contains(_finalResult);
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
        
        return $"Kampen er ferdig. Du tippet {isBetCorrectText}.";
    }
}