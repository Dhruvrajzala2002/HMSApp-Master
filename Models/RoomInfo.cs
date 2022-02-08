namespace HMSApp.Models
{
    public class RoomInfo : StudAttModel
    {
        public RoomInfo()
        {

        }

        public int EnterRoomNo { get; set; }

        public bool Ac { get; set; }

        public bool NonAc { get; set; }

        public bool TwoSeated { get; set; }

        public bool ThreeSeated { get; set; }

        public bool Wifi { get; set; }

        public bool Charges { get; set; }


    }
}

 