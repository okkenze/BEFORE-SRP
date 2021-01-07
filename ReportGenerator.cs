using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEFORESRP
{
    public class ReportGenerator
    {
        private List<User> _user;

        public ReportGenerator()
        {
            _user = new List<User>();
        }


        public string GenerateReportASString()
        {
            //get data from built in UserEntry
            _user.Add(new User() { FirstName = "Okechukwu", LastName = "Nmema" });
            

            //format data into json
            return JsonConvert.SerializeObject(_user);

        }
        //User model
        private class User
        {
           
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
