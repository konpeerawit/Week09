using System.Drawing;
using System.Drawing.Drawing2D;

namespace Week09
{
    internal class HatchBrush
    {
        private object s;
        private Color violet;

        public HatchBrush(System.Drawing.Drawing2D.HatchStyle darkVertical, object s)
        {
            this.s = s;
        }

        public HatchBrush(HatchStyle darkVertical, object s, Color violet) : this(darkVertical, s)
        {
            this.violet = violet;
        }
    }
}