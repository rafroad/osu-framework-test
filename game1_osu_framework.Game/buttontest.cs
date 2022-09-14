using System.Drawing;
using System.Security.Cryptography;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Input.Events;
using osu.Framework.Input.StateChanges;
using osu.Framework.Screens;
using osuTK;
using osuTK.Graphics;
using osuTK.Input;
using SixLabors.ImageSharp;

namespace game1_osu_framework.Game
{
    public class button1 : CompositeDrawable
    {
        public void Button1()
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
        }
        private ScreenStack sc;
        [BackgroundDependencyLoader]
        private void load()
        {
            new BasicTextBox
            {
                Origin = Anchor.Centre,
                Anchor = Anchor.Centre,
                Width=27,
                Height=27,
                Y=90,
            };
        }
    }
}
