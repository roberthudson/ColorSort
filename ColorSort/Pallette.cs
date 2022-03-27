using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSort
{
    public static class Pallette
    {
        private static Color[] colors =
        {
            System.Drawing.Color.FromArgb(3, 181, 240),
            System.Drawing.Color.FromArgb(157, 112, 88),
            System.Drawing.Color.FromArgb(215, 83, 84),
            System.Drawing.Color.FromArgb(76, 209, 103),
            System.Drawing.Color.FromArgb(67, 115, 230),
            System.Drawing.Color.FromArgb(246, 133, 240),
            System.Drawing.Color.FromArgb(248, 180, 77),
            System.Drawing.Color.FromArgb(148, 151, 156),
            System.Drawing.Color.FromArgb(254, 243, 95),
            System.Drawing.Color.FromArgb(155, 85, 190),
            System.Drawing.Color.FromArgb(253, 120, 24)
    };

        //public static Color Cyan { get { return Color.FromArgb(3, 181, 240); } }
        //public static Color Brown { get { return Color.FromArgb(157, 112, 88); } }
        //public static Color Red { get { return Color.FromArgb(215,83,84); } }
        //public static Color Green { get { return Color.FromArgb(76,209,103); } }
        //public static Color Blue { get { return Color.FromArgb(67,115,230); } }
        //public static Color Pink { get { return Color.FromArgb(246,133,240); } }
        //public static Color LtOrange { get { return Color.FromArgb(248,180,77); } }
        //public static Color Gray { get { return Color.FromArgb(148, 151, 156); } }
        //public static Color Yellow { get { return Color.FromArgb(254, 243, 95); } }
        //public static Color Purple { get { return Color.FromArgb(155, 85, 190); } }
        //public static Color Orange { get { return Color.FromArgb(253, 120, 24); } }

        internal static Color Color(WaterColor color)
        {
            return colors[(int)color];
        }
    }

    public enum WaterColor
    {
        Cyan=0,
        Brown=1,
        Red=2,
        Green=3,
        Blue=4,
        Pink=5,
        LtOrange=6,
        Gray=7,
        Yellow=8,
        Purple=9,
        Orange=10
    }
}
