using System;

namespace TicTacToeCore
{
    public class Cell
    {
        public MarkType _mark;

        public Cell()
        {
            _mark = MarkType.EMPTY;
        }
               
        public void MarkCell(MarkType mark)
        {
            if (_mark==MarkType.EMPTY)
            {
                _mark = mark;
            }         
            throw new Exception("Cell already marked");   
        }
        public MarkType GetMark
        {
            get
            {
                return _mark;
            }
        }
    }
}
