using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using FFmpeg.AutoGen;
using NuGet.Configuration;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Animations;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Input.Events;
using osu.Framework.Input.StateChanges;
using osu.Framework.Screens;
using osuTK;
using osuTK.Input;
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
        private BasicTextBox btb;
        private BasicPasswordTextBox bptb;
        private Sprite sp1;
        popup pp1=new popup();
        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            Button b1;
            InternalChildren = new Drawable[]
            {
                btb = new BasicTextBox()
                {
                    Colour = Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(200, 30),
                    PlaceholderText = "user"
                },
                bptb = new BasicPasswordTextBox()
                {
                    Colour = Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(200, 30),
                    PlaceholderText = "password",
                    Y = 30,
                },
                new BasicButton()
                {
                    Text = "Login",
                    Colour = Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(200, 30),
                    Y = 60,
                    FlashColour = FrameworkColour.Green,
                    Action = () => pp1.Show(),

                },
            };
        }
    }
}



