using HMSApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HMSApp.DataAccessLayer
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class StudentDataLayer
    {
        SqlConnection con = new SqlConnection("Data Source=windev2112Eval;Initial Catalog=HMS;Integrated Security=True ; TrustServerCertificate=True");
        public Dictionary<bool,string> StudentOperation(StudentModel student, string action)
        {
            Dictionary<bool, string> result = new Dictionary<bool, string>();
            try
            {
                SqlCommand cmd = new SqlCommand("AddOrUpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action" , action);
                cmd.Parameters.AddWithValue("@StudentId" ,student.StudentId);
                cmd.Parameters.AddWithValue("@FirstName",student.FirstName); 
                cmd.Parameters.AddWithValue("@LastName",student.LastName);
                cmd.Parameters.AddWithValue("@Gender",student.Gender);
                cmd.Parameters.AddWithValue("@BirthDate", student.BirthDate.ToString());
                cmd.Parameters.AddWithValue("@Address",student.Address);
                cmd.Parameters.AddWithValue("@City", student.City);
                cmd.Parameters.AddWithValue("@State",student.State);
                cmd.Parameters.AddWithValue("@Pincode",student.Pincode);
                cmd.Parameters.AddWithValue("@ContactNo",student.ContactNo);
                cmd.Parameters.AddWithValue("@Email",student.Email);
                cmd.Parameters.AddWithValue("@FatherName",student.FatherName);
                cmd.Parameters.AddWithValue("@MotherName",student.MotherName);
                cmd.Parameters.AddWithValue("@ParentsContactNo",student.ParentsContactNo);
                cmd.Parameters.AddWithValue("@ParentsAddressFlag",student.ParentsAddressFlag.ToString());
                cmd.Parameters.AddWithValue("@BloodGroup",student.BloodGroup);      
                cmd.Parameters.AddWithValue("@JoinDate",student.JoinDate.ToString());
                cmd.Parameters.AddWithValue("@LeaveDate",student.LeaveDate.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                result.Add(true, string.Format("Student record action {0} successfully", action));
                return result;
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                result.Add(false, string.Format("There is an issue with operation due to : {0}", ex.Message.ToString()));
                return result;
            }
        }
    }
}
