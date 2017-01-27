using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleForm
{
    class Appointment : IComparable<Appointment>
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string server { get; set; }
        public string room { get; set; }
     
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

        public Appointment(DateTime s, DateTime e, string se, string r)
        {
            start = s;
            end = e;
            server = se;
            room = r;
        }

        public bool isIntercepted(DateTime dt)
        {
            return (start <= dt && dt < end);
        }

        public override string ToString()
        {
            if(server!= "" || room!="")
                return start.ToShortTimeString() + "-" + end.ToShortTimeString()+" ("+server +", "+room+")";
            else
                return start.ToShortTimeString() + "-" + end.ToShortTimeString(); 
        }


        public int CompareTo(Appointment other)
        {
            return start.CompareTo(other.start);
        }
    }
}
