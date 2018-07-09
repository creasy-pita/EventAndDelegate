using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndDelegate
{
    class Alarm
    {
        // 发出语音警报
        public void MakeAlert(int param)
        {
            Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", param);
        }
    }
}
