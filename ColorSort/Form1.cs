using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            colorTube1.SetColor(1, WaterColor.Orange);
            colorTube1.SetColor(2, WaterColor.LtOrange);
            colorTube1.SetColor(3, WaterColor.Gray);
            colorTube1.SetColor(4, WaterColor.Brown);

            Randomizer r = new Randomizer();

            //draw tubes
            SuspendLayout();
            int left = 50;
            int top = 50;
            for (int i=0; i<13; i++)
            {
                if (i == 7)
                {
                    top = 200;
                    left = 75;
                }
                ColorTube tube = new ColorTube()
                {
                    Id = i,
                    Top = top,
                    Left = left,
                    Height = 100,
                    Width= 50,
                    Visible = true,                    
                };
                tube.Clicked += Tube_Clicked;

                //fill 1st 11 tubes; last 2 are empty
                if (i < 11)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        tube.SetColor(j + 1, r.GetNextColor());
                    }
                }

                Controls.Add(tube);

                left += tube.Width + 20;
            }
            ResumeLayout();

        }

        private void Tube_Clicked(object sender, EventArgs e)
        {
            var tube = (ColorTube)sender;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorTube1.Selected = !colorTube1.Selected;
        }
    }
}
