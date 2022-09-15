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

namespace game1_osu_framework.Game
{
    public class MainScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            InternalChildren = new Drawable[]
            {
                new Sprite
                {
                    Texture=textures.Get("mc_bg"),
                    RelativeSizeAxes = Axes.Both,
                },
                new SpriteText
                {
                    Y = 20,
                    Text = "Login",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 100)
                },
                new Sprite
                {
                   Y=160,
                   Texture=textures.Get("logo"),
                   Anchor = Anchor.TopCentre,
                   Origin = Anchor.TopCentre,
                },
                new screentest
                {
                    Anchor = Anchor.Centre,  
                },
            };
        }
    }
}
    
