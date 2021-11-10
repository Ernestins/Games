using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTank.Landscape
{
    class Horizon
    {
        private int Width;
        public Map Map { get; set; }


        public Horizon(Map owner, int w)
        {
            this.Map = owner;
            this.Width = w;
        }

        public Horizon Generate()
        {
            //StartHight
            //Delta +1 0 -1
            //Array[Width] ... Random
            return this;
        }
    }
}
