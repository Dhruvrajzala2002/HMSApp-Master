using System;

namespace HMSApp.Models
{
    public class StudInstModel : StudentModel
    {
        public int InstituteName { get; set; }
        public int CourseName { get; set; }
        public int Class { get; set; }
        public int InstituteAddress { get; set; }
        public int InstituteContactNo { get; set; }
        public DateTime InstJoinDate { get; set; }
        public DateTime InstLeaveDate { get; set; }

    }
}