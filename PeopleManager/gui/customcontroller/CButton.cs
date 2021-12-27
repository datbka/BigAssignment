using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using System.ComponentModel;

namespace PeopleManager.gui.customcontroller
{
   public class CButton : IconButton
    {
        private int bordersize = 0;
        private int borderradius = 0;
        private Color borderColor = Color.PaleVioletRed;
        [Category("Custom Property")]
        public int Bordersize
        {
            get => bordersize; set
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        public int Borderradius { get => borderradius; set 
            { borderradius = value;
                this.Invalidate();
            } 
        }
        public Color BorderColor { get => borderColor; set 
            { borderColor = value;
                this.Invalidate();
            } 
        }
        
        public CButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(100, 50);
            this.BackColor = Color.MediumSlateBlue;
            this.BackColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0,0,this.Width,this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width -0.8F, this.Height-1);

            if(borderradius > 2)
            {
                using(GraphicsPath pathSurface = GetFigurePath(rectSurface,borderradius))
                    using(GraphicsPath pathBorder = GetFigurePath(rectBorder, borderradius - 1F))
                    using(Pen penSurface = new Pen(this.Parent.BackColor,2))
                    using(Pen penBorder = new Pen(borderColor,bordersize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (bordersize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (bordersize >= 1)
                {
                    using(Pen penBorder = new Pen(borderColor, bordersize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += Parent_BackColorChanged;
        }

        private void Parent_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
