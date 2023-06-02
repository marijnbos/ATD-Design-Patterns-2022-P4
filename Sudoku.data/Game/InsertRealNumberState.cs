using Sudoku.data.Boards;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;

namespace Sudoku.data.Game;

public class InsertRealNumberState : IGameState
{
    public void Move(PlayerInput input, GameContext _context)
    {
        switch (input)
        {
            
            //hier help gebruikt om naar andere state te gaan
            case PlayerInput.Help:
                _context.state = new insertingHelpNumbers();
                return;
            default:
                //write a message to the console that the input is not valid and help is only allowed to switch to other state
                return;
        }
    }

    public void insert(string value, GameContext _context)
    {
        //if the input is a number
        //insert the number in the board
        throw new NotImplementedException();
    }

    public  void solve(GameContext _context)
    {
        //switch to soloving state
        _context.state = new GameSolvingState();
    }


    public  void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public  void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public  void OnNext(IConcreteBoard value)
    {
        
    }
}