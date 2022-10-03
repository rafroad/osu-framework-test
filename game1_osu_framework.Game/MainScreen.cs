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
using osu.Framework;
using osu.Framework.Testing;

namespace game1_osu_framework.Game
{
    public class MainScreen : Screen
    {
        private BasicTextBox btb;
        private BasicPasswordTextBox bptb;
        private Sprite sp1;
        private Popover po;
        private ScreenStack stack;
        private BasicButton bb1;
        private BasicButton exitbutton;
        private screentest screen1;
        private IScreen iscreen;
        private MainScreen mainScreen;
        private BasicPopover wrong;
        string username;
        string password;
        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            InternalChildren = new Drawable[]
            {
                new Box
                {
                    Colour=Colour4.AntiqueWhite,
                    RelativeSizeAxes = Axes.Both,
                    RelativePositionAxes = Axes.Both,
                    TextureRelativeSizeAxes= Axes.Both,
                    Origin=Anchor.Centre,
                    Anchor=Anchor.Centre,
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
                btb = new BasicTextBox
                {
                    Colour = Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(200, 30),
                    PlaceholderText = "user"
                },
                bptb = new BasicPasswordTextBox
                {
                    Colour = Colour4.AliceBlue,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(200, 30),
                    PlaceholderText = "password",
                    Y = 30,
                },
                bb1=new BasicButton
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
                exitbutton = new BasicButton
                {
                    Text = "exit",
                    Colour = Colour4.DarkRed,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(90, 30),
                    Y = -370,
                    X=-635,
                    FlashColour = Colour4.DarkRed,
                    Action = () => Exit(),
                }
            };
        }
        public void Push()
        {
            username = btb.Text;
            password = bptb.Text;
            if(username == "test" && password == "test")
            {
                this.Push(screen1 = new screentest { RelativeSizeAxes = Axes.Both });
                bptb.Text = string.Empty;
                btb.Text = string.Empty;
            }
        }
        public void Exit()
        {
            Exit();
        }
    }
}
    
