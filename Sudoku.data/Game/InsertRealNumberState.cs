using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Game.State;
using Sudoku.data.Input.Enum;

namespace Sudoku.data.Game;

public class InsertRealNumberState : IGameState
{
    public void Move(PlayerInput input, GameContext context)
    {
        switch (input)
        {

            //hier help gebruikt om naar andere state te gaan
            case PlayerInput.Help:
                context.State = new InsertingHelpNumbers();
                return;
            default:
                //write a message to the console that the input is not valid and help is only allowed to switch to other state
                return;
        }
    }

    public void insert(string value, GameContext context)
    {
        int row = context.Board.SelectedCell.X;
        int col = context.Board.SelectedCell.Y;
        var oldCell = context.Board.Cells[row][col];
        context.Board.Cells[row][col] = new CellFactory().factorMethod(oldCell.Group, char.Parse(value), true);
    }

    public void solve(GameContext context)
    {
        //switch to soloving state
        context.State = new GameSolvingState();
        context.solve();
    }


    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(IConcreteBoard value)
    {

    }
}