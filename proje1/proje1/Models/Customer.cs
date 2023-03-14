using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje1.Models
{
    public class Customer
    {
        public int CusID { get; set; }
        public String CusName { get; set; }
        public String CusLastName { get; set; }
        public String CusEmail { get; set; }
        public String CusPassword { get; set; }
        public int Suspended { get; set; }
        public int Incorrect { get; set; }

        public Customer()
        {

        }

        public Customer(int cusID, String cusName, String cusLastName, String cusEmail, String cusPassword, int suspended, int incorrect)
        {
            CusID = cusID;
            CusName = cusName;
            CusLastName = cusLastName;
            CusEmail = cusEmail;
            CusPassword = cusPassword;
            Suspended = suspended;
            Incorrect = incorrect;
        }
       
    }
}