using System;
using System.Windows.Forms;

namespace ColorSort
{
    public partial class ColorTube : UserControl
    {
        public event EventHandler Clicked;

        public ColorTube()
        {
            InitializeComponent();

            DrawControls();
        }

        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; DrawControls(); }
        }

        public int Id { get; internal set; }

        private void DrawControls()
        {
            int top = _selected ? 10 : 21;
            for (int i=0; i<4; i++)
            {
                VerticalProgressBar v = (VerticalProgressBar)Controls["verticalProgressBar" + (i + 1)];
                v.Top = top + v.Height * i;
            }
        }

        public void SetColor(int level, WaterColor color)
        {
            VerticalProgressBar pb = (VerticalProgressBar)Controls["verticalProgressBar" + level];
            pb.ForeColor = Pallette.Color(color);
            pb.Value = 100;
        }

        private void ColorTube_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
