using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace dotnetuz_signup.ServiceLayer
{
     class API
    {
        public static readonly string BASE_URL = "https://localhost:7263/api/MovieControllers";
        public static readonly string GET_USER = BASE_URL + "Person/Get";
        public static readonly string DELETE_USER = BASE_URL + "Person/Get";
        public static readonly string PUT_USER = BASE_URL + "Person/Get";
        public static readonly string UPDATE_USER = BASE_URL + "Person/Get";
    }
}
