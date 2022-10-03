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

namespace game1_osu_framework.Game.Visual
{
    abstract class notificationoverlay: OverlayContainer
    {
        private void load()
        {
            Child = new Container
            {
                Children= new Drawable[]
                {
                    new Box
                    {
                        Size = new Vector2(100,4),
                        Colour= Colour4.White,
                        Anchor = Anchor.CentreLeft,
                        Origin = Anchor.CentreLeft,
                    }
                }
            };
        }
    }
}
