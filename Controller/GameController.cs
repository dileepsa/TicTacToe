namespace TicTacToe;

public class GameController
{
    private readonly Game _game;
    private readonly View _view;

    public GameController(Game game, View view)
    {
        _game = game;
        _view = view;
    }

    public void Start()
    {
        while (_game.State == GameState.Running)
        {
            _view.DisplayPlayerInfo(_game.CurrentPlayer);
            _view.DisplayBoard(_game.Board);
            _view.DisplayPrompt();
            _game.Play(_view.GetCell());
        }

        _view.DisplayWinner(_game.CurrentPlayer);
    }
}