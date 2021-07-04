namespace GameOfLife
{
   public class Map
   {
      private int[,] _map;

      public Map(int rows, int cols)
      {
         _map = new int[rows, cols];
      }

      public override string ToString()
      {
         string result = "";

         for (int i = 0; i < _map.GetLength(0); i++)
         {
            result += "\n";

            for(int j = 0; j < _map.GetLength(1); j++)
               result += _map[i, j] + "  ";
         }

         return result;
      }
   }
}