using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Builder
{
   class PersonFatBuilder:PersonBuilder
    {
        public PersonFatBuilder(Graphics g, Pen p) : base(g, p) { }

        public override void BuildHead()
        {
            g.DrawEllipse(p, 50, 20, 30, 30);
        }

        public override void BuildBody()
        {
            g.DrawRectangle(p, 45, 50, 40, 50);
        }

        public override void BuildArmLeft()
        {
            g.DrawLine(p, 50, 50, 30, 100);
        }

        public override void BuildArmRight()
        {
            g.DrawLine(p, 80, 50, 100, 100);
        }

        public override void BuildLegLeft()
        {
            g.DrawLine(p, 60, 100, 45, 150);
        }

        public override void BuildLegRight()
        {
            g.DrawLine(p, 70, 100, 85, 150);
        }
    }
}
