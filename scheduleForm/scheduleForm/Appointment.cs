using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleForm
{
    class Appointment
    {
        private DateTime start;
        private DateTime end;
        private string server;
     
        public Appointment(DateTime s, DateTime e)
        {
            start = s;
            end = e;
        }
        public Appointment(DateTime s, DateTime e, string se)
        {
            start = s;
            end = e;
            server = se;
        }

        public bool isIntercepted(DateTime dt)
        {
            return (start > dt && dt < end);
        }


    }
}
