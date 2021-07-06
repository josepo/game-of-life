namespace GameOfLife
{
   public class Cell
   {
      public bool Alive { get; private set; }

      public Cell(bool alive)
      {
         Alive = alive;
      }
   }
}