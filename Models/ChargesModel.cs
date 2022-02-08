namespace HMSApp.Models
{
    public class ChargesModel : StudentModel
    {
        public ChargesModel()
        {
           // "Data Source=windev2112Eval;Initial Catalog=HMS;Integrated Security=True"
        }

        public int ChargeName { get; set; }

        public int ChargeDetail { get; set; }

        public int Amountpaid { get; set; }

        public int Chargespaid { get; set; }

        public int ChargeDueDate { get; set; }

    }
}