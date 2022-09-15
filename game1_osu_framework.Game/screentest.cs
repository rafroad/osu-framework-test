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
        private Popover po;
        private ScreenStack screenStack;
        private ScreenStack screenStack2;
        private Screen screen1;
        private IScreen iscreen;
        screen2 screen2 = new screen2();
        MainScreen mainScreen;
        [BackgroundDependencyLoader]
        private void load()
        {
            screenStack = new ScreenStack { RelativeSizeAxes = Axes.Both };
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
                    Action = () => Push(),
                },
            };
        }
        private ScreenStack sc;
        public void Push()
        {
            screenStack.Push(new screen2());
        }
    }
}




