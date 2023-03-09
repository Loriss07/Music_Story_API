using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStory
{
    public partial class CircleAvatar : PictureBox
    {
        private int borderSize = 2;
        private int borderRadius = 40;
        private float gradientAngle = 90F;
        private Color borderGradientTop = Color.DodgerBlue;
        private Color borderGradientBottom = Color.Azure;

        //Proprietà
        public CircleAvatar()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(120, 120);
            InitializeComponent();
        }
        public int BorderSize 
        { 
            get => borderSize;
            set { 
                borderSize = value;
                this.Invalidate();
            }  
        }
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        public Color BorderGradientTop
        {
            get => borderGradientTop;
            set
            {
                borderGradientTop = value;
                this.Invalidate();
            }
        }
        public Color BorderGradientBottom
        {
            get => borderGradientBottom;
            set
            {
                borderGradientBottom = value;
                this.Invalidate();
            }
        }

        //Override
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Width);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graphics = pe.Graphics;
            var rectSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectSmooth, -borderSize, -borderSize);
            var SmoothSize = borderSize > 0 ? borderSize * 3 : 1;

            using(var borderGradientColor = new LinearGradientBrush(rectBorder,borderGradientTop,borderGradientBottom, gradientAngle))
            using(var pathRegion = new GraphicsPath())
            using(var penSmooth = new Pen(Parent.BackColor, SmoothSize))
            using(var penBorder = new Pen(borderGradientColor,SmoothSize))
            {
                pathRegion.AddEllipse(rectSmooth);
                Region = new Region(pathRegion);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawEllipse(penSmooth, rectSmooth);

                if (borderSize > 0)
                {
                    graphics.DrawEllipse(penBorder, rectBorder);
                }
            }
            Size = new Size(Width, Width);
        }
    }
}
