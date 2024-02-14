using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetTrainingBatch3.ConsoleApp.Models;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DotNetTrainingBatch3.ConsoleApp.HttpClientExamples
{
    public class HttpClientExample
    {
        public async Task Run()
        {
            //await Read();
            await ReadJsonPlaceholder();
        }

        //https://jsonplaceholder.typicode.com/
        private async Task Read()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7131/api/Blog");
            //HttpResponseMessage response2 = client.GetAsync("https://localhost:7131/api/Blog").Result;
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonStr);

                //JsonConvert.SerializeObject() // C# object to JSON
                //JsonConvert.DeserializeObject() // JSON to C# object

                List<BlogModel> lst = JsonConvert.DeserializeObject<List<BlogModel>>(jsonStr)!;

                foreach (BlogModel item in lst)
                {
                    Console.WriteLine(item.BlogId);
                    Console.WriteLine(item.BlogTitle);
                    Console.WriteLine(item.BlogAuthor);
                    Console.WriteLine(item.BlogContent);
                }
            }
        }

        private async Task ReadJsonPlaceholder()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonStr);

                //JsonConvert.SerializeObject() // C# object to JSON
                //JsonConvert.DeserializeObject() // JSON to C# object

                List<JsonPlaceholderModel> lst = JsonConvert.DeserializeObject<List<JsonPlaceholderModel>>(jsonStr)!;

                foreach (JsonPlaceholderModel item in lst)
                {
                    Console.WriteLine(item.title);
                    Console.WriteLine(item.body);
                    Console.WriteLine(item.userId);
                    Console.WriteLine(item.id);
                }
            }
        }
    }
}
