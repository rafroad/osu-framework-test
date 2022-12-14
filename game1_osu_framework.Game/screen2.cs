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
    public class screen2: Screen
    {
        private Visual.notificationoverlay notif;
        private Box bg;
        private BasicMenu bm;
      public screen2()
        {
            InternalChildren = new Drawable[]
            {
                bg=new Box
                {
                    RelativeSizeAxes = Axes.Both,
                    Colour = Color4.Tomato,
                    Origin = Anchor.Centre,
                    Anchor = Anchor.Centre
                },
                bm=new BasicMenu(Direction.Horizontal,false)
                {
                     Size = new Vector2(200, 30),
                     Origin = Anchor.Centre,
                     Anchor= Anchor.Centre,
                     Colour = Color4.Violet,
    
                },
            };
        }
    }
}
