using osu.Framework;
using osu.Framework.Platform;

namespace game1_osu_framework.Game.Tests
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost("visual-tests"))
            using (var game = new game1_osu_frameworkTestBrowser())
                host.Run(game);
        }
    }
}
