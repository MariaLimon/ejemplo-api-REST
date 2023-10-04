using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // URL del endpoint para buscar por nombre de país
        string baseUrl = "https://restcountries.com/v3.1/name/";
        string countryName = "Brasil";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + countryName);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    // Aquí puedes deserializar los datos JSON y acceder a la información del país.
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
