using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;

namespace Sudoku.data.Cells.Factory
{
    class CellFactory : CreatorCell
    {
        public CellFactory() : base()
        {
            
        }
        public override ProductCell factorMethod(int group, char cellValue)
        {
            return new EmptyCell(group, cellValue);
        }


       
    }
}