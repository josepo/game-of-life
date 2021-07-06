using Xunit;

namespace GameOfLife
{
   public class GameFactoryTest
   {
      [Fact]
      public void GameCreation()
      {
         Game game = GameFactory.From(new int[,] {
            { 0, 1 },
            { 1, 1 }
         });

         Assert.False(game.Get(0, 0).Alive);
         Assert.True(game.Get(0, 1).Alive);
         Assert.True(game.Get(1, 0).Alive);
         Assert.True(game.Get(1, 1).Alive);
      }
   }
}