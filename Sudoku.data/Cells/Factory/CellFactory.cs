namespace Sudoku.data.Cells
{
    internal class CellFactory : CreatorCell
    {
        private Dictionary<CellState, Cell> factory { get; set; }

        CellFactory(Dictionary<CellState, Cell> factory)
        {
            this.factory = factory;
        }


        public override Cell factorMethod()
        {
            foreach (CellState cell in CellState.GetValues(typeof(CellState)))
            {
                //todo dit beter uitschrijven
            }
            return new EmptyCell(0);
        }
    }
}