namespace EasyAhri
{
    using System.Windows.Forms;
    using EnsoulSharp.SDK.MenuUI.Values;

    internal class MenuWrapper
    {       
        public class Combat
        {
            public static readonly MenuBool Q = new MenuBool("q", "Use Q");
            public static readonly MenuBool W = new MenuBool("w", "Use W");
            public static readonly MenuBool E = new MenuBool("e", "Use E");
        }

        public class Harass
        {
            public static readonly MenuBool Q = new MenuBool("q", "Use Q");
            public static readonly MenuBool W = new MenuBool("w", "Use W");
            public static readonly MenuBool E = new MenuBool("e", "Use E", false);
            public static readonly MenuSlider Mana = new MenuSlider("minmana", "^ Min ManaPercent <= x%", 60);
        }
        public class KillAble
        {
            public static readonly MenuBool Q = new MenuBool("q", "Use Q");
            public static readonly MenuBool W = new MenuBool("w", "Use W");
            public static readonly MenuBool E = new MenuBool("e", "Use E");
        }

        public class Draw
        {
            public static readonly MenuBool Q = new MenuBool("q", "Draw Q Range");
            public static readonly MenuBool W = new MenuBool("w", "Draw W Range");
            public static readonly MenuBool E = new MenuBool("e", "Draw E Range");
            public static readonly MenuBool R = new MenuBool("r", "Draw R Range");
        }

    }
}