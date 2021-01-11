using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// User Information to be submitted through the User creation form in the User/Index view
    /// </summary>
    public class UserModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}