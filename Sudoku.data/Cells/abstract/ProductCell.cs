using Sudoku.data.Cells.@enum;
using Sudoku.data.Color;

namespace Sudoku.data.Cells.@abstract
{
    //todo introduce composit pattern to group cells
    public abstract class ProductCell
    {
        private CellState State { get; set; }
        public int Group { get; }
        public abstract char Value { get; set; }
        public abstract ColorEnum getCollor();
        public bool Selected { get; set; }

        protected ProductCell(int group, char value, bool selected)
        {
            Group = group;
            Value = value;
            Selected = selected;
        }
    }
}