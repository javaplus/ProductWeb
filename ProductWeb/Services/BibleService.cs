using ProductWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ProductWeb.Services
{
    public class BibleService
    {
        private static readonly HttpClient client = new HttpClient();


        public BibleVerse getJohn316()
        {
           
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            Task<String> streamTask = client.GetStringAsync("http://localhost:5000/BibleVerse");
            String jsonString = streamTask.Result;
            Console.WriteLine("Raw json response=" + jsonString);
            JsonReader jsonReader = new JsonTextReader(new StringReader(jsonString));
            JsonSerializer jsonSerializer = new JsonSerializer();
            BibleVerse response = jsonSerializer.Deserialize<BibleVerse>(jsonReader);

            return response;
        }
    }
}
