using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SimpleDotNetWebServiceExample.Models;

namespace SimpleDotNetWebServiceExample.Services
{
    public class DataPersistenceService
    {
        private HttpClient _client;
        public DataPersistenceService(HttpClient client)
        {
            _client = client;
        }

        public void SendData(string persistenceUrl, FormData data)
        {

            var json = JsonSerializer.Serialize(data);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = _client.PatchAsync(persistenceUrl, content).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
        }
    }
}
