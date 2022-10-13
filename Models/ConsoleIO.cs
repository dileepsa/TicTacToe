namespace TicTacToe;

public interface IO
{
    public void Output(string printableItem);
    public int GetInput();
}

public class ConsoleIO : IO
{
    public void Output(string printableItem)
    {
        Console.WriteLine(printableItem);
    }

    public int GetInput()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
}