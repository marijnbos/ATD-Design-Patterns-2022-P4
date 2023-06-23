using Sudoku.data.Cells.Factory;
using Sudoku.data.Game.State;
using Sudoku.data.Input.Enum;

namespace Sudoku.data.Game;

public class InsertingHelpNumbers : IGameState
{
    public void Move(PlayerInput input, GameContext context)
    {
        switch (input)
        {
            case PlayerInput.EditorToggle:
                context.State = new InsertRealNumberState();
                return;
            default:
                return;
        }
    }

    public void Insert(string value, GameContext context)
    {
        var row = context.Board.SelectedCell.X;
        var col = context.Board.SelectedCell.Y;
        var oldCell = context.Board.Cells[row][col];
        if (oldCell.State == Cells.@enum.CellState.FilledSystem)
            return;
        var buildnumber = context.Board.Cells[row][col].HelperNumbers;
        context.Board.Cells[row][col] = new CellFactory().factorMethod(oldCell.Group, char.Parse("0"), true,
            Cells.@enum.CellState.FilledUser, buildnumber);
        context.Board.Cells[row][col].HelperNumbers.Add(int.Parse(value));
    }
}