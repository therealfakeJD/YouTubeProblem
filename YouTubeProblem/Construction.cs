using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeProblem
{
    class Construction
    {
        public Construction()
        {
            Process.Start(@"chrome.exe", "https://www.youtube.com/watch?v=hl_9_q_uLF8");
            Console.ReadLine();
        }

        //Everything I have read about destructors says they are basically useless.  
    }
}
