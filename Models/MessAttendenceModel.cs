using System;

namespace HMSApp.Models
{
    public class MessAttendenceModel : StudentModel
    {
        public MessAttendenceModel()
        {

        }

        public DateTime CurrentDate { get; set; }

        public bool Breakfast { get; set; }

        public bool Lunch { get; set; }


        public bool Dinner { get; set; }

    }
}