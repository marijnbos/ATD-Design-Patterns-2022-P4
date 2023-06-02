using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;

namespace Sudoku.data.Cells.Factory
{
    internal class CellFactory : CreatorCell
    {
        private Dictionary<CellState, ProductCell> Factory { get; set; }

        CellFactory(Dictionary<CellState, ProductCell> factory)
        {
            this.Factory = factory;
        }


        public override ProductCell factorMethod()
        {
            foreach (CellState cell in CellState.GetValues(typeof(CellState)))
            {
                //todo dit beter uitschrijven
            }
            return new EmptyCell(0);
        }
    }
}