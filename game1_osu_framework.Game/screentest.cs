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
using osu.Framework.Audio;
using osu.Framework.Audio.Track;
using osu.Framework;
using osuTK.Graphics;

namespace game1_osu_framework.Game
{
    public class screentest : Screen
    {
        private BasicButton b1;
        private ScreenStack stack;
        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new Drawable[]
            {
                new Box
                {
                    Colour=Colour4.Blue,
                    RelativeSizeAxes = Axes.Both,
                    RelativePositionAxes = Axes.Both,
                    TextureRelativeSizeAxes= Axes.Both,
                    Origin=Anchor.Centre,
                    Anchor=Anchor.Centre,
                },
                new SpriteText()
                {
                    Y = 20,
                    Text = "success",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 100)
                },
                b1=new BasicButton()
                {
                    Text = "back",
                    Colour = Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(200, 30),
                    Y = 60,
                    FlashColour = FrameworkColour.Green,
                    Action = () => this.Push(new MainScreen()),
                },
            };
        }
    }
}




