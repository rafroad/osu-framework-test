using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Animations;
using osu.Framework.Graphics.Containers;
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
        private BasicPopover bp;
        private BasicTextBox btb;
        private BasicPasswordTextBox bptb;
        private Sprite sp1;
        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            InternalChildren = new Drawable[]
            {
                btb=new BasicTextBox()
                {
                    Colour=Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin= Anchor.Centre,
                    Size=new Vector2(200, 30),
                    PlaceholderText="user"
                },
                bptb=new BasicPasswordTextBox()
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
                    FlashColour = FrameworkColour.Green,
                    Action = () => bp.Show(),

                },
                bp = new BasicPopover()
                {
                   new Box
                   {
                      Colour=Colour4.SlateGray,
                      Anchor = Anchor.Centre,
                      Origin= Anchor.Centre,
                      Size=new Vector2(200, 200),
                   },
                   new BasicButton()
                   {
                      Colour=Colour4.Red,
                      Anchor = Anchor.Centre,
                      Origin= Anchor.Centre,
                      Size=new Vector2(50, 50),
                      FlashColour= Colour4.DarkRed,
                      X=-70,
                      Y=-70,
                      Action = () => bp.Hide(),
                      
                   },
                   new SpriteText()
                   {
                     Text="Confirm?",
                     Colour=Colour4.AliceBlue,
                     Anchor = Anchor.Centre,
                     Origin= Anchor.Centre,
                   },
                },
            };

            
        }
    }

}
