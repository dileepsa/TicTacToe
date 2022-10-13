namespace TicTacToe;

public class Player
{
    public Player(string name, Symbol symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    public string Name { get; }
    public Symbol Symbol { get; }
}

public enum Symbol
{
    X,
    O,
    N
}