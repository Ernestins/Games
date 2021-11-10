using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTank.Landscape
{
    class Map
    {
        public int ScaleHight { get; set; }
        public int ScaleWidth { get; set; }

        public Horizon Horizon { get; set; }

        public Map(int h = 100, int w = 100)
        {
            ScaleHight = h;
            ScaleWidth = w;
        }

        public Map CreateHorizon()
        {
            this.Horizon = new Horizon(this, ScaleWidth);
            return this;
        }

    }
}
