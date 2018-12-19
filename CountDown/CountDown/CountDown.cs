using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Count_Down
{
    class CountDown
    {
        private int remainingTime;
        private static System.Timers.Timer aTimer;

        public CountDown(int time)
        {
            this.remainingTime = time;
        }

        public void Start()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public void Stop()
        {

        }

        public int RemainingTime
        {
            get
            {
                return remainingTime;
            }

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            remainingTime--;
            Console.WriteLine(RemainingTime);
        }
    }
}
