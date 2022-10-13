namespace TicTacToe;

public class View
{
    private readonly IO _io;

    public View(IO io)
    {
        _io = io;
    }

    public int GetCell()
    {
        return _io.GetInput();
    }

    private bool IsEmpty(Symbol symbol)
    {
        return symbol == Symbol.N;
    }

    public void DisplayPlayerInfo(Player player)
    {
        _io.Output($"Current Player: {player.Name}, Symbol: {player.Symbol}");
    }

    public void DisplayPrompt()
    {
        _io.Output("Enter the cell no: ");
    }

    public void DisplayWinner(Player player)
    {
        _io.Output($"Hurreyyyy!!! {player.Name} WON The game...");
    }

    public void DisplayBoard(Symbol[] board)
    {
        for (var index = 0; index < board.Length; index += 3)
        {
            var first = IsEmpty(board[index]) ? (index + 1).ToString() : board[index].ToString();
            var second = IsEmpty(board[index + 1]) ? (index + 2).ToString() : board[index + 1].ToString();
            var third = IsEmpty(board[index + 2]) ? (index + 3).ToString() : board[index + 2].ToString();

            _io.Output($"{first}  {second}  {third} \n");
        }
    }
}