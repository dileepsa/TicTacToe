namespace TicTacToe;

class StartGame
{
    public static void Main()
    {
        var game = Game.CreateGame();
        var view = new View(new ConsoleIO());
        var gameController = new GameController(game, view);
        gameController.Start();
    }
}
