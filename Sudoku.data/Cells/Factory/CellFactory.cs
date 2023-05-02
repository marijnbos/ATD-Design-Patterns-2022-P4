namespace Sudoku.data.Cells
{
    internal class CellFactory : Creator
    {
        public override ICell factorMethod(string type)
        {
            //TODO finish this logic
            switch (type)
            {
                default:
                    return null;
            }
        }
    }
}
