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
            case PlayerInput.EditorToggle:
                context.State = new InsertingHelpNumbers();
                return;
            default:
                return;
        }
    }

    public void Insert(string value, GameContext context)
    {
        var row = context.Board.SelectedCell.X;
        var col = context.Board.SelectedCell.Y;
        var selectedCell = context.Board.Cells[row][col];
        var buildnumber = context.Board.Cells[row][col].HelperNumbers;
        var cellFactory = new CellFactory();

        if (selectedCell.State == CellState.Empty)
        {
            selectedCell = cellFactory.factorMethod(
                selectedCell.Group,
                char.Parse(value),
                true,
                context.Board.SolvedBoard.Cells[row][col].Value.ToString() == value ? CellState.FilledUser : CellState.FaultyCell,
                buildnumber
            );

            context.Board.Cells[row][col] = selectedCell;

        }
        else if (selectedCell.State == CellState.FilledUser && selectedCell.Value == char.Parse(value))
        {
            selectedCell = cellFactory.factorMethod(selectedCell.Group, ' ', true, CellState.Empty, buildnumber);
            context.Board.Cells[row][col] = selectedCell;
        }
        else if (selectedCell.State == CellState.FilledUser && selectedCell.Value != int.Parse(value))
        {
            selectedCell = cellFactory.factorMethod(selectedCell.Group, char.Parse(value), true, CellState.FilledUser,
                buildnumber);
            context.Board.Cells[row][col] = selectedCell;
        }
    }
}