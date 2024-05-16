using System;
using System.Net.Http;

namespace AdminPanel.Services
{

    public class ConnectionService : HttpClient
    {

        public ConnectionService(string baseuri) 
        {
            BaseAddress = new Uri(baseuri);
        }

        public void SetAuth(string token) 
        {
            DefaultRequestHeaders.Remove("authorization");
            DefaultRequestHeaders.Add("authorization",
                        string.Format("bearer {0}", token));
        }
    }
}
