namespace Customer.WEB.Helpers
{
    public interface IApiServices
    {
        Task<string> GetJsonAsync(string urlBase, string token);
    }
}
