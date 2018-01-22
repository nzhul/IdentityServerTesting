using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleClientUserLogin
{
    public class Program
    {
        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {
            IDictionary<string, string> formData = new Dictionary<string, string>();
            formData.Add("grant_type", "password");
            formData.Add("username", "dd@abv.bg");
            formData.Add("password", "123123");
            formData.Add("scope", "api1");
            formData.Add("clientId", "ro.client");
            formData.Add("clientSecret", "secret");

            HttpResponseMessage response;

            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5000/connect/token")
            {
                Content = new FormUrlEncodedContent(formData)
            };

            HttpClient client = new HttpClient();

            response = await client.SendAsync(request).ConfigureAwait(false);
        }
    }
}
