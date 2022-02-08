using System;

namespace HMSApp.Models
{
    public class StudAttModel
    {
        public StudAttModel()
        {
        }

        public int StudentId { get; set; }


        public DateTime CurrentDate { get; set; }


        public bool Morning { get; set; }


        public bool Evening { get; set; }
    }
}
    