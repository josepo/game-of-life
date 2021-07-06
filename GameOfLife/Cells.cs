using System.Collections.Generic;

namespace GameOfLife
{
   public class Cells
   {
      private Cell[,] Map { get; set; }
      public int Rows { get; private set; }
      public int Cols { get; private set; }

      public Cells(int rows, int cols)
      {
         Map = new Cell[rows, cols];
         Rows = rows;
         Cols = cols;
      }

      public void Set(int i, int j, Cell cell)
      {
         Map[i, j] = cell;
      }

      public Cell Get(int i, int j)
      {
         return Map[i, j];
      }

      public List<Cell> Neighbors(int i, int j)
      {
         List<Cell> neighbors = new List<Cell>();
         
         int maxRow = Rows - 1;
         int maxCol = Cols - 1;

         int rowStart = (i == 0) ? 0 : (i - 1);
         int rowEnd = (i == maxRow) ? maxRow : (i + 1);

         int colStart = (j == 0) ? 0 : (j - 1);
         int colEnd = (j == maxCol) ? maxCol : (j + 1);

         for (int row = rowStart; row <= rowEnd; row++)
            for (int col = colStart; col <= colEnd; col++)
            {
               if ((row != i) || (col != j))
               {
                  Cell cell = Get(row, col);

                  neighbors.Add(cell);
               }
            }

         return neighbors;
      }
   }
}