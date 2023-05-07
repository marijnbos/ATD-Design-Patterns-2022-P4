using Sudoku.data.Color;

namespace Sudoku.data
{
    //todo introduce composit pattern to group cells
    public abstract class Cell
    {
        private int group { get; }
        public abstract char value { get; set; }
        public abstract ColorEnum getCollor();
        protected Cell(int group)
        {
            this.group = group;
        }
    }
}