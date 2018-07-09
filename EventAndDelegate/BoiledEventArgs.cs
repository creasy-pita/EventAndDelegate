using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndDelegate
{
    public class BoiledEventArgs:EventArgs
    {
        public int temprature;
        public BoiledEventArgs(int temprature)
        {
            this.temprature = temprature;
        }
    }
}
