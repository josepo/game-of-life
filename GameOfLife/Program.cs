using System;

namespace GameOfLife
{
   class Program
   {
      static void Main(string[] args)
      {
         Map map = new Map(3, 4);
         
         Console.WriteLine(map);
      }
   }
}
