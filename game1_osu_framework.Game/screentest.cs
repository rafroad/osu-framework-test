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
using SixLabors.ImageSharp;

namespace game1_osu_framework.Game
{
    public class screentest : CompositeDrawable
    {
        public void Screentest2()
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
        }
        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new Drawable[]
            {
                new BasicTextBox()
                {
                    Colour=Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin= Anchor.Centre,
                    Size=new Vector2(200, 30),
                    PlaceholderText="user"
                },
                new BasicPasswordTextBox()
                {
                    Colour=Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin= Anchor.Centre,
                    Size=new Vector2(200, 30),
                    PlaceholderText="password",
                    Y=30,
                },
                new BasicButton()
                {
                    Text="submit",
                    Colour=Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin= Anchor.Centre,
                    Size=new Vector2(200, 30),
                    Y=60,
                },
            };
            
        }
    }

}
