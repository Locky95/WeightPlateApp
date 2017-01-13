using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeightPlateApp
{
    public class SupplementAlarm
    {
        DateTime alarm;

        public SupplementAlarm()
        {

        }
        public void setAlarm(DateTime alarm)
        {
            this.alarm = alarm;
        }
        public DateTime getAlarm()
        {
            return alarm;
        }
       
        public String checkAlarm(DateTime alarm)
        {   
            String txt = "not working" + alarm.ToString("hh:mm tt");
            if (alarm.ToString("hh:mm tt").Equals( DateTime.Now.ToString("hh:mm tt")))
            {
                txt = "Take Your supplements";

            }
            return txt;
        }
    }
}
