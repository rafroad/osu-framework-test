using osu.Framework.Platform;
using osu.Framework;
using game1_osu_framework.Game;

namespace game1_osu_framework.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"game1_osu_framework"))
            using (osu.Framework.Game game = new game1_osu_frameworkGame())
                host.Run(game);
        }
    }
}
