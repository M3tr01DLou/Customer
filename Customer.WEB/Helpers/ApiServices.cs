using System.Net.Http.Headers;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Customer.WEB.Helpers
{
    public class ApiServices : IApiServices
    {
        private readonly HttpClient _httpClient;

        public ApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetJsonAsync(string urlBase, string token)
        {
            try
            {
                if (String.IsNullOrEmpty(token))
                {
                    return string.Empty;
                }
                else
                {
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
                    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    _httpClient.DefaultRequestHeaders.Add("Authorization", token);

                    return await _httpClient.GetStringAsync(new Uri(urlBase));
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
