using osu.Framework.Graphics;
using NUnit.Framework;

namespace game1_osu_framework.Game.Tests.Visual
{
    [TestFixture]
    public class TestSceneSpinningBox : game1_osu_frameworkTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        public TestSceneSpinningBox()
        {
            Add(new screen
            {
                Anchor = Anchor.Centre,
            });
        }
    }
}
