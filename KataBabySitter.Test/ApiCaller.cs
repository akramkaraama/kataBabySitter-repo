using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace KataBabySitter.Test
{
   public  class ApiCaller
    {
        private const string URL = "http://localhost:63411/api/CalculateTime";


        public static double CallApi(int start, int end)
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new Uri("http://localhost:63411/api/CalculateTime/") })
            {
                 var response = client.PostAsync("Broadcast/Order", null).Result;
            }
                
       

            return 0.00;
        }
    }
}
