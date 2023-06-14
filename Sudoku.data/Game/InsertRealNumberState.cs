using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@enum;
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
            case PlayerInput.EditorToggle:
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
        var selectedCell = context.Board.Cells[row][col];
        var buildnumber = context.Board.Cells[row][col].HelperNumbers;
        var cellFactory = new CellFactory();

        if (selectedCell.State == CellState.Empty)
        {
            selectedCell = cellFactory.factorMethod(selectedCell.Group, char.Parse(value), true, CellState.FilledUser,buildnumber);
            context.Board.Cells[row][col] = selectedCell;
        }
        else if (selectedCell.State == CellState.FilledUser && selectedCell.Value == char.Parse(value))
        {
            selectedCell = cellFactory.factorMethod(selectedCell.Group, ' ', false, CellState.Empty,buildnumber);
            context.Board.Cells[row][col] = selectedCell;
        }
        else if (selectedCell.State == CellState.FilledUser && selectedCell.Value != int.Parse(value))
        {
            selectedCell = cellFactory.factorMethod(selectedCell.Group, char.Parse(value), true, CellState.FilledUser,buildnumber);
            context.Board.Cells[row][col] = selectedCell;
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

    public void OnNext(IConcreteBoard value)
    {

    }
}