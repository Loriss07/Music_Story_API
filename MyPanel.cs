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
    public partial class CardComponents : Panel
    {
        private int borderRadius = 20;
        private float gradientAngle = 20F;
        private Color gradientTopColor = Color.LightSteelBlue;
        private Color gradientBottomColor = Color.Gainsboro;
        public CardComponents()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(450, 200);
            InitializeComponent();
        }

        public int BorderRadius 
        {
            get => borderRadius;
            set { borderRadius = value;
                this.Invalidate();
            }
        }
        public float GradientAngle 
        { 
            get => gradientAngle;
            set { 
                gradientAngle = value;
                this.Invalidate();
            }  
        }
        public Color GradientTopColor 
        { 
            get => gradientTopColor;
            set {
                gradientTopColor = value;
                this.Invalidate();
            }  
        }
        public Color GradientBottomColor 
        { 
            get => gradientBottomColor;
            set {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }
        //Metodi
        private GraphicsPath GetPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.AddArc(rect.X - radius, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        //Metodi override
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradiente
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.GradientBottomColor, this.GradientAngle);
            Graphics graphicsCard = e.Graphics;
            graphicsCard.FillRectangle(brush, ClientRectangle);

            //BorderRadius
            RectangleF rect = new RectangleF(0,0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetPath(rect, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2)) 
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);

                }
            }
            else
            {
                this.Region = new Region(rect);
            }
        }
       
    }
}
