﻿using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Graphics;
using osuTK;
using osu.Framework.Graphics.Containers;
using osu.Framework.Allocation;

namespace game1_osu_framework.Game
{
    public class popup : CompositeDrawable
    {
        private Popover po;
        private void load()
        {
            new BasicPopover()
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Size = new Vector2(400, 400),
                X = -175,
                Y = -250,
                Children = new Drawable[]
                {
                        new SpriteText
                        {
                            Text="are you sure",
                            Font = FontUsage.Default.With(size: 50),
                            Anchor=Anchor.Centre,
                            Origin=(Anchor)Anchor.Centre,

                        },
                        new BasicButton
                        {
                           Origin= Anchor.Centre,
                           Anchor=Anchor.Centre,
                           Text="confirm?",
                           X=-100,
                           Y=-200,
                           Size=new Vector2(200, 30),
                           Action=()=>po.Hide(),

                        }


                },
            };
        }
    }
}