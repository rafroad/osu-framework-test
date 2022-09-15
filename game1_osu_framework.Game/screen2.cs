using System.Runtime.CompilerServices;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Input.Events;
using osu.Framework.Input.StateChanges;
using osu.Framework.Screens;
using osuTK.Graphics;
using osuTK.Graphics.ES20;
using SixLabors.ImageSharp;
using osuTK;
using osu.Framework.Graphics.Textures;
using System;

namespace game1_osu_framework.Game
{
    public class screen2 : Screen
    {
        private ScreenStack screenStack;
        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            InternalChildren = new Drawable[]
            {
                new Sprite
                {
                    Texture=textures.Get("mc_bg"),
                    RelativeSizeAxes = Axes.Both,
                    RelativePositionAxes = Axes.Both,
                    TextureRelativeSizeAxes= Axes.Both,
                    Origin=Anchor.Centre,
                    Anchor=Anchor.Centre,
                },
                new SpriteText
                {
                    Text = "success",
                    Anchor= Anchor.Centre,
                    Origin=Anchor.Centre,
                },
                new BasicButton()
                {
                    Text = "return",
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
        protected void Push()
        {
            screenStack.Push(new MainScreen());
        }
    }
}
