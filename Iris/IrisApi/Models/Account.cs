using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrisApi.Model
{
    public class Account
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] ProfileImage { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }


        public Account()
        {

        }

    }
}
