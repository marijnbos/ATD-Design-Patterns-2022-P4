namespace Sudoku.data.Cells
{
    internal class CellFactory : CreatorCell
    {
        private Dictionary<CellState, ProductCell> factory { get; set; }

        CellFactory(Dictionary<CellState, ProductCell> factory)
        {
            this.factory = factory;
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