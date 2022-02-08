using System;

namespace HMSApp.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int Pincode { get; set; }
        public int ContactNo { get; set; }
        public string? Email { get; set; }


        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public int ParentsContactNo { get; set; }
        public bool ParentsAddressFlag { get; set; }


        public string? BloodGroup { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LeaveDate { get; set; }
    }
}

