using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace _15Puzzle
{
    public class MyTimer : Timer
    {

        private Label _timerLabel;
        private int _time;
        public MyTimer(Label l)
        {
            this._timerLabel = l;
            this.Tick += new EventHandler(TimerEventProcessor);
            this.Interval = 1000;
        }

        private void TimerEventProcessor(Object myObject,EventArgs myEventArgs)
        {
            _time++;
            _timerLabel.Text = _time.ToString();
        }

        public void RestartTimer() {
            _time = 0;
            _timerLabel.Text = "0";
        }
    }

}
