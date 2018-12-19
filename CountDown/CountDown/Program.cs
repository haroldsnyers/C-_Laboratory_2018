using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Count_Down;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown countdown = new CountDown(600);
            countdown.Start();
            Console.WriteLine("time : " + countdown.RemainingTime);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("time2 : " + countdown.RemainingTime);
        }
    }
}