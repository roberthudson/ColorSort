using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSort
{
    public class Randomizer
    {
        private List<WaterColor> colors;

        Random r = new Random();

        public Randomizer()
        {
            colors = new List<WaterColor>();

            foreach (var color in (WaterColor[])Enum.GetValues(typeof(WaterColor)))
            {
                for (int i=0; i<4; i++)
                {
                    colors.Add(color);
                }
            }
        }

        public WaterColor GetNextColor()
        {            
            int i = r.Next(colors.Count-1);
            var color = colors[i];
            colors.Remove(color);
            return color;
        }
    }
}
