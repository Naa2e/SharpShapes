using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public override float Area()
        {
            return Top * Left;
        }

        public Rectangle(float width, float height)
        {
            this.Top = width;
            this.Right = height;
            this.Bottom = width;
            this.Left = height;
        }
    }

}
