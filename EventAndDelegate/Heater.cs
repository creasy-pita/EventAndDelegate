using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndDelegate
{
    class Heater
    {
        public delegate void BoilEventHandler(int temprature);
        public event BoilEventHandler BoilEvent;

        private int temperature; // 水温
        // 烧水
        public void BoilWater()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;

                if (temperature > 95)
                {
                    BoilEvent(temperature);
                }
            }
        }
    }
}
