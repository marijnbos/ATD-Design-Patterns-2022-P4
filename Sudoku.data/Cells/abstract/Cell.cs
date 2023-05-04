using Sudoku.data.Color;

namespace Sudoku.data
{
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