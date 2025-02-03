// Work files here 
using Pastel;
using System.Drawing;

namespace buty1.src
{
    class Work1
    {

        // Use a single HttpClient instance for the application lifecycle
        private static readonly HttpClient client = new HttpClient();

        public static async Task Work1_Banner_1()
        {
            try
            {
                // Replace with the actual API URL
                string url = "https://snips.sh/f/vYOIhLB4A2?r=1";

                // Make the HTTP GET request
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read the response body as a string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Print the ANSI string directly to the console
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                // Handle HTTP request errors
                Console.WriteLine(@"
--------------------------------
[-] Exception Caught!
[-] Message: {0}
".Pastel(Color.Red),
e.Message.Pastel(Color.Red));
            }
            catch (Exception e)
            {
                // Handle any other exceptions
                Console.WriteLine(@"
--------------------------------
[-] Exception Caught!
[-] Message: {0}".Pastel(Color.Red),
e.Message.Pastel(Color.Red));
            }
        }
    }
}