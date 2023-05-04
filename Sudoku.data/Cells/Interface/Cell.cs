using Sudoku.data.Color;
using static Sudoku.data.Color.ColorEnum;

namespace Sudoku.data
{
    public abstract class Cell
    {
        public Cell(int group)
        {
            this.group = group;
        }
        private int group { get;}
        public abstract char value { get; set; }
        public abstract ColorEnum getCollor();
    }
}