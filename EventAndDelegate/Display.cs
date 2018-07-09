using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndDelegate
{
    class Display
    {
        // 显示水温
        public  void ShowMsg(int param)
        {
            Console.WriteLine("Display：水快开了，当前温度：{0}度。", param);
        }
    }
}
