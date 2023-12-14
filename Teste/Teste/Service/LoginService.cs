using System.Text;
using Teste.Models;

public class LoginService
{
    public async Task<object> AccessLogin(ResquestLogin login)
    {
        using (HttpClient httpClient = new())
        {
            try
            {
                const string url = "https://test-api-y04b.onrender.com/signIn";

                var content = new StringContent($"{{\"user\":\"{login.User}\",\"password\":\"{login.Password}\"}}", Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    await response.Content.ReadAsStringAsync();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Erro na requisição HTTP: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
