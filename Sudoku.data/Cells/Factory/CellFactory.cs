using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;

namespace Sudoku.data.Cells.Factory
{
    class CellFactory : CreatorCell
    {
        public CellFactory() : base()
        {
        }

        public override ProductCell factorMethod(int group, char cellValue, bool selected)
        {
            switch (cellValue)
            {
                case '0':
                    return new EmptyCell(group, cellValue, selected);
                default:
                    return new FilledSystemCell(group, cellValue, selected);
            }
        }
    }
}