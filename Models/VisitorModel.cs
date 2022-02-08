using System;

namespace HMSApp.Models
{
    public class VisitorModel : StudentModel
    {
        public DateTime VisitDate { get; set; }
        public string? EntryTime { get; set; }
        public string? ExitTime { get; set; }
        public string? Purposeofvisit { get; set; }
        public string? Relation { get; set; }
        public int VisitorContactNo { get; set; }

    }
}
