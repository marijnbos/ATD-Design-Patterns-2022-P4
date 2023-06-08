using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;

namespace Sudoku.data.Cells.Factory
{
    class CellFactory : CreatorCell
    {
        public CellFactory() : base()
        {
        }

        public override ProductCell factorMethod(int group, char cellValue, bool selected, CellState state)
        {
            switch (state)
            {
                case CellState.Empty:
                    return new EmptyCell(group, cellValue, selected, state);
                case CellState.FilledSystem:
                    return new FilledSystemCell(group, cellValue, selected, state);
                case CellState.FilledUser:
                    return new FilledUserCell(group, cellValue, selected, state);
                case CellState.FaultyCell:
                    return new FaultyCell(group, cellValue, selected, state);
                case CellState.NotACell:
                    return new NotACell(group, cellValue, selected, state);
                case CellState.CorrectCell:
                    return new CorrectCell(group, cellValue, selected, state);
                default:
                    throw new ArgumentException("Invalid cell state.");
            }
        }
    }
}