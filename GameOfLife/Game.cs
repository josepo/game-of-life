using System.Linq;

namespace GameOfLife
{
   public class Game
   {
      private Cells Cells { get; set; }

      public Game(Cells cells)
      {
         Cells = cells;
      }

      public Game Run()
      {
         Cells cells = new Cells(Cells.Rows, Cells.Cols);

         for (int i = 0; i < Cells.Rows; i++)
            for (int j = 0; j < Cells.Cols; j++)
            {
               int alive = Cells.Neighbors(i, j).Count(n => n.Alive);

               cells.Set(i, j, new Cell(alive >= 2));
            }

         return new Game(cells);
      }

      public Cell Get(int i, int j)
      {
         return Cells.Get(i, j);
      }

      public override string ToString()
      {
         string result = "";

         for (int i = 0; i < Cells.Rows; i++)
         {
            result += "\n";

            for(int j = 0; j < Cells.Cols; j++)
               result += Cells.Get(i, j) + "  ";
         }

         return result;
      }
   }
}