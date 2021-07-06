using Xunit;

namespace GameOfLife.Tests
{
    public class MapTest
    {
        [Fact]
        public void CellWithOneAliveNeighboursDies()
        {
           Game game = new Game(new int[,]
           {
              { 0, 0, 0 },
              { 0, 1, 0 },
              { 0, 1, 0 }
           });

           game.Run();

           Assert.False(game.Get(1, 1).Alive);
        }
    }
}
