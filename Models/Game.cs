namespace TicTacToe;

public class Game
{
    private readonly Player[] _players;

    private readonly List<int[]> _winningPositions = new()
    {
        new[] { 1, 2, 3 },
        new[] { 4, 5, 6 },
        new[] { 7, 8, 9 },
        new[] { 1, 4, 7 },
        new[] { 2, 5, 8 },
        new[] { 3, 6, 9 },
        new[] { 3, 5, 7 },
        new[] { 1, 5, 9 }
    };

    public GameState State;
    public Symbol[] Board { get; }

    public Player CurrentPlayer { get; private set; }

    private Game(Player[] players)
    {
        _players = players;
        CurrentPlayer = players[0];
        State = GameState.Running;
        Board = new[] { Symbol.N, Symbol.N, Symbol.N, Symbol.N, Symbol.N, Symbol.N, Symbol.N, Symbol.N, Symbol.N };
    }

    private bool IsCompleted()
    {
        foreach (var winningPos in _winningPositions)
            if (HasCombinations(winningPos))
                return true;

        return false;
    }

    private bool HasCombinations(int[] winningPo)
    {
        foreach (var position in winningPo)
        {
            if (CurrentPlayer.Symbol != Board[position - 1]) return false;

            ;
        }

        return true;
    }

    private void UpdateBoard(int position)
    {
        Board[position - 1] = CurrentPlayer.Symbol;
    }

    public void Play(int position)
    {
        UpdateBoard(position);

        if (IsCompleted())
        {
            State = GameState.Won;
            return;
        }

        ;

        NextPlayer();
    }

    private void NextPlayer()
    {
        CurrentPlayer = CurrentPlayer == _players[0] ? _players[1] : _players[0];
    }

    public static Game CreateGame()
    {
        var player1 = new Player("Sai", Symbol.X);
        var player2 = new Player("Dileep", Symbol.O);

        var players = new Player[2];

        players[0] = player1;
        players[1] = player2;
        var game = new Game(players);
        return game;
    }

    public override string ToString()
    {
        return "This is the Game object";
    }
}