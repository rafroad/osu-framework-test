using osu.Framework.Allocation;
using osu.Framework.Platform;
using NUnit.Framework;

namespace game1_osu_framework.Game.Tests.Visual
{
    [TestFixture]
    public class TestScenegame1_osu_frameworkGame : game1_osu_frameworkTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        private game1_osu_frameworkGame game;

        [BackgroundDependencyLoader]
        private void load(GameHost host)
        {
            game = new game1_osu_frameworkGame();
            game.SetHost(host);

            AddGame(game);
        }
    }
}
