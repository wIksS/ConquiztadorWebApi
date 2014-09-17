namespace GameDb.Models
{
    public enum GameState
    {
        WaitingForSecondPlayer = 0,
        TurnRed = 1,
        TurnGreen = 2,
        GameWonByRed = 3,
        GameWonByGreen = 4
    }
}
