using System.Text;

namespace http_client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

                await SendGetRequest(client);

                await SendPostRequest(client);
            }
        }

        static async Task SendGetRequest(HttpClient client)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("posts/1");
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                Console.WriteLine("GET-request:");
                Console.WriteLine(responseData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error GET-request: {ex.Message}");
            }
        }

        static async Task SendPostRequest(HttpClient client)
        {
            try
            {
                var postData = new
                {
                    title = "foo",
                    body = "bar",
                    userId = 1
                };

                string json = System.Text.Json.JsonSerializer.Serialize(postData);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("posts", content);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                Console.WriteLine("POST-request");
                Console.WriteLine(responseData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error POST-request: {ex.Message}");
            }
        }
    }
}
