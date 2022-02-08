using System;

namespace HMSApp.Models
{
    public class RoomAllocationModel : StudentModel
    {

        public RoomAllocationModel()
        {

        }
        public DateTime CurrentDate { get; set; }

        public bool Breakfast { get; set; }

        public bool Lunch { get; set; }


        public bool Dinner { get; set; }

    }
}