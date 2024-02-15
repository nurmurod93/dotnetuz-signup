using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetuz_signup.ServiceLayer.User
{
     class UserModel
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string UsertName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("carID")]
        public int CarID { get; set; }

    }
}
