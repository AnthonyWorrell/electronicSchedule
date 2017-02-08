using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleForm
{
    class Appointment : IComparable<Appointment>
    {
        /// <summary>
        /// Get or Set appointment start time
        /// </summary>
        public DateTime start { get; set; }
        /// <summary>
        /// Get or Set appointment end time
        /// </summary>
        public DateTime end { get; set; }
        /// <summary>
        /// Get or Set appointment server
        /// </summary>
        public string server { get; set; }
        /// <summary>
        /// Get or Set appointment room
        /// </summary>
        public string room { get; set; }
     
        /// <summary>
        /// New Appointment with start time and end time
        /// </summary>
        /// <param name="Start">Appointment start time</param>
        /// <param name="End">Appointment end time</param>
        public Appointment(DateTime Start, DateTime End)
        {
            start = Start;
            end = End;
        }
        /// <summary>
        /// new appointment with start time, end time, and server
        /// </summary>
        /// <param name="Start">Appointment start time</param>
        /// <param name="End">Appointment end time</param>
        /// <param name="Server">Appointment server</param>
        public Appointment(DateTime Start, DateTime End, string Server)
        {
            start = Start;
            end = End;
            server = Server;
        }
        /// <summary>
        /// New appointment with start time, end time, server, and room
        /// </summary>
        /// <param name="Start">Appointment start time</param>
        /// <param name="End">Appointment end time</param>
        /// <param name="Server">Appointment server</param>
        /// <param name="Room">Appointment room</param>
        public Appointment(DateTime Start, DateTime End, string Server, string Room)
        {
            start = Start;
            end = End;
            server = Server;
            room = Room;
        }
        /// <summary>
        /// checks if the passed in time intercepts appointment
        /// </summary>
        /// <param name="dt">Passed in time</param>
        /// <returns>True if appointment is intercepted, False if not</returns>
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

        /// <summary>
        /// compareable appointment for sorting
        /// </summary>
        /// <param name="other">other appointment being compared</param>
        /// <returns></returns>
        public int CompareTo(Appointment other)
        {
            return start.CompareTo(other.start);
        }
    }
}
