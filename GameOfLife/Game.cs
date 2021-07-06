using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
   public class Game
   {
      private Cell[,] Cells { get; set; }
      private int Rows { get; set; }
      private int Cols { get; set; }

      public Game(Cell[,] cells)
      {
         Cells = cells;
         Rows = cells.GetLength(0);
         Cols = cells.GetLength(1);
      }

      public Game Run()
      {
         Cell[,] cells = new Cell[Rows, Cols];

         for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
            {
               int alive = Neighbors(i, j).Count(n => n.Alive);

               cells[i, j] = new Cell(alive >= 2);
            }

         return new Game(cells);
      }

      private List<Cell> Neighbors(int i, int j)
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

      public Cell Get(int i, int j)
      {
         return Cells[i, j];
      }

      public override string ToString()
      {
         string result = "";

         for (int i = 0; i < Rows; i++)
         {
            result += "\n";

            for(int j = 0; j < Cols; j++)
               result += Cells[i, j] + "  ";
         }

         return result;
      }
   }
}