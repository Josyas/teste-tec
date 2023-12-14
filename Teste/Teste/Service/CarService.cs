using System.Net.Http.Json;
using System.Text.Json;
using Teste.Models;

namespace Teste.Service
{
    public class CarService
    {
        public async Task<List<ResponseCarModel>> GetCarBrands()
        {
            using (HttpClient httpClient = new())
            {
                try
                {
                    const string url = "https://parallelum.com.br/fipe/api/v1/carros/marcas";

                    var result = await httpClient.GetFromJsonAsync<ResponseCarModel[]>(url);

                    return new List<ResponseCarModel>(result);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception($"Erro na requisição HTTP: {ex.Message}");
                }
            }
        }

        public async Task<ResponseCarBrand> GetCarCodigo(string idModel)
        {
            using (HttpClient httpClient = new())
            {
                try
                {
                    string url = "https://parallelum.com.br/fipe/api/v1/carros/marcas/" + idModel + "/modelos";
                    var result = await httpClient.GetStringAsync(url);

                    if (result != null)
                    {
                        var resultJson = JsonSerializer.Deserialize<ResponseCarBrand>(result);

                        return resultJson;
                    }
                    else
                    {
                        throw new Exception("erro ao buscar as marcas.");
                    }
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception($"Erro na requisição HTTP: {ex.Message}");
                }
            }
        }
    }
}
