using Sudoku.data.Boards;
using Sudoku.data.Game.Enum;

namespace Sudoku.data.Game;

public class Game : IObserver<IBoard>
{
    DisplayOptions DisplayOption { get; }
    Board board { get; }
    

    public Game(Board board, DisplayOptions displayOption)
    {
        this.board = board;
        this.board.Subscribe(this);
        DisplayOption = displayOption;
    }

    public void Move(PlayerInput input)
    {
        switch (input)
        {
            case PlayerInput.up:
                break;
            case PlayerInput.right:
                break;
            case PlayerInput.down:
                break;
            case PlayerInput.left:
                break;
            default:
                return;
        }
    }


    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(IBoard value)
    {
        
    }
}